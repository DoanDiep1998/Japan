
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private DBContextsDataContext db = new DBContextsDataContext();
        public ActionResult Index()
        {
            var lstDanhMuc = db.DanhMucs.ToList();
            ViewBag.lstDanhMuc = lstDanhMuc;
            var lstBanner = db.Baners.ToList();
            ViewBag.lstBanner1 = lstBanner.Where(x => x.location == 1);
            ViewBag.totalBanner1 = lstBanner.Where(x => x.location == 1).ToList().Count;
            ViewBag.lstBanner2 = lstBanner.Where(x => x.location == 2);

            // nội dung của trang index
            var listSubCategory = db.DanhMucCons.ToList();
            var listItems = db.Items.ToList();
            List<DetailDatas> lstData = new List<DetailDatas>();
            foreach (var item in lstDanhMuc)
            {
                DetailDatas detailDatas = new DetailDatas();
                detailDatas.Id = item.Id;
                detailDatas.Name = item.Name;

                var   listSubCategoryByID = listSubCategory.Where(x => x.ID_DanhMucCha == item.Id).ToList();
                List < SubCategory > lstSubCategory = new List< SubCategory>();
                foreach (var itemSub in listSubCategoryByID)
                {
                    SubCategory sub = new SubCategory();
                    sub.Id = itemSub.Id; 
                    sub.Name = itemSub.Name;

                    List<Items> lstItems = new List<Items>();
                    var lstItemsByID = listItems.Where(x => x.ID_DanhMucCon == itemSub.Id).OrderByDescending(x=>x.CreateDate).Take(4).ToList();
                    foreach (var ite in lstItemsByID)
                    {
                        Items it = new Items();
                        it.Id = ite.Id;
                        it.Tile = ite.Tile;
                        it.Contents = ite.Contents;
                        it.CreateDate = ite.CreateDate;
                        it.Images = ite.Images;
                        lstItems.Add(it);
                    }
                    sub.lstItems = lstItems;

                    lstSubCategory.Add(sub);
                }
                detailDatas.lstSubCategory = lstSubCategory;
                lstData.Add(detailDatas);
            }
            return View(lstData);
        }

        public ActionResult DanhMuc(int Id =0, int SubId =0 ,int Page =1)
        {
            try
            {
                var lstDanhMuc = db.DanhMucs.ToList();
                ViewBag.lstDanhMuc = lstDanhMuc;
                ViewBag.danhMucActive = Id;
                ViewBag.pageActive = Page;

                var danhMuc = lstDanhMuc.FirstOrDefault(x => x.Id == Id);
                DetailDatas detailDatas = new DetailDatas();
                detailDatas.Id = danhMuc.Id;
                detailDatas.Name = danhMuc.Name;

                var listSubCategoryByID = db.DanhMucCons.Where(x => x.ID_DanhMucCha == danhMuc.Id).ToList();
                ViewBag.danhMucCon = listSubCategoryByID;
                var SubCategory = new List<DanhMucCon>();
                if (SubId !=0)
                {
                    SubCategory = listSubCategoryByID.Where(x => x.Id == SubId).ToList();
                }
                else
                {
                     SubCategory.Add(listSubCategoryByID.FirstOrDefault());
                }
                ViewBag.danhMucConActive = SubCategory.FirstOrDefault().Id;
                List<SubCategory> lstSubCategory = new List<SubCategory>();
                var listItems = db.Items.ToList();

                foreach (var itemSub in SubCategory)
                {
                    SubCategory sub = new SubCategory();
                    sub.Id = itemSub.Id;
                    sub.Name = itemSub.Name;

                    List<Items> lstItems = new List<Items>();
                    var lstItemsByID = listItems.Where(x => x.ID_DanhMucCon == itemSub.Id).OrderByDescending(x => x.CreateDate).ToList();
                    decimal totalPageDe = Math.Round( (decimal)lstItemsByID.Count / 9,3);
                    ViewBag.totalPage = Math.Ceiling(totalPageDe);

                    lstItemsByID = lstItemsByID.Skip((Page - 1) * 9).Take(9).ToList();
                   
                    foreach (var ite in lstItemsByID)
                    {
                        Items it = new Items();
                        it.Id = ite.Id;
                        it.Tile = ite.Tile;
                        it.Contents = ite.Contents;
                        it.CreateDate = ite.CreateDate;
                        it.Images = ite.Images;
                        lstItems.Add(it);
                    }
                    sub.lstItems = lstItems;
                    lstSubCategory.Add(sub);
                }
                detailDatas.lstSubCategory = lstSubCategory;
                return View(detailDatas);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult ChiTiet(int Id)
        {
            try
            {
                var lstItems = db.Items.ToList();
                ViewBag.LstItemsOder = lstItems.OrderByDescending(x => x.CreateDate).Take(4).ToList();
                var Item = db.Items.FirstOrDefault(x => x.Id == Id);
                var lstDanhMuc = db.DanhMucs.ToList();
                ViewBag.lstDanhMuc = lstDanhMuc;
                ViewBag.Message = "Your contact page.";
                ViewBag.paramContact = "2";
                return View(Item);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }
        public PartialViewResult GetContact(string Id ="") 
        {
            if (Id == "")
                return null;

            ViewBag.listItems = new SelectList(db.Items, "Id", "Tile");
            return PartialView();
        }
        public string ContactSend(string name, string email, string sdt, int IdItem)
        {
            try
            {
                BaoGia bg = new BaoGia();
                bg.Email = email;
                bg.HotenKH = name;
                bg.SoDienThoai = sdt;
                bg.itemID = IdItem;
                bg.Images = "0";
                db.BaoGias.InsertOnSubmit(bg);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception)
            {
                return "0";
            }
            
        }
    }
}