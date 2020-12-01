using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;



namespace WebApplication6.Areas.Admin.Controllers
{
    public class ItemsController : Controller
    {
        private DBContextsDataContext db = new DBContextsDataContext();

        // GET: Admin/Items
        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }

        // GET: Admin/Items/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.First(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Admin/Items/Create
        public ActionResult Create()
        {
            ViewBag.ID_DanhMucCon = new SelectList(db.DanhMucCons, "Id", "Name");
            return View();
        }

        // POST: Admin/Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create( Item item, HttpPostedFileBase picture)
        {
            string pictures = "";
            
            for (int i = 0; i < Request.Files.Count; i++)
            {
                // lấy ra từng file
                picture = Request.Files[i];
                // lấy tên file
                string fileName = picture.FileName;
                // lưu file
                picture.SaveAs(Server.MapPath(@"~/Content/FileUpload/") + fileName);
                pictures += "/Content/FileUpload/" + fileName + ";";
             

            }
            //add nội dung
            item.Images = pictures;

            if (ModelState.IsValid)
            {
                db.Items.InsertOnSubmit(item);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: Admin/Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.First(x => x.Id == id);
            
            if (item == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_DanhMucCon = new SelectList(db.DanhMucCons, "Id", "Name");
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit( Item item, HttpPostedFileBase picture)
        {
            string pictures = "";
            if (picture !=null)
            {
             
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    // lấy ra từng file
                    picture = Request.Files[i];
                    // lấy tên file
                    string fileName = picture.FileName;
                    // lưu file
                    picture.SaveAs(Server.MapPath(@"~/Content/FileUpload/") + fileName);
                    pictures += "/Content/FileUpload/" + fileName + ";";

                }

            }
            else
            {
                pictures = item.Images;
            }
            if (ModelState.IsValid)
            {
                Item items = db.Items.First(x => x.Id == item.Id);
                if (items == null)
                {
                    return HttpNotFound();
                }
                items.ID_DanhMucCon = item.ID_DanhMucCon;
                items.Images = pictures;
                items.Tile = item.Tile;
                items.Contents = item.Contents;
                items.CreateDate = item.CreateDate;
                db.SubmitChanges();
                ViewBag.ID_DanhMucCon = new SelectList(db.DanhMucCons, "Id", "Name");
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Admin/Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.First(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Admin/Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.First(x => x.Id == id);
            db.Items.DeleteOnSubmit(item);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
