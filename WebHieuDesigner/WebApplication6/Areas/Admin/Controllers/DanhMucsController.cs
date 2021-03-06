﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace WebApplication6.Areas.Admin.Controllers
{
    public class DanhMucsController : Controller
    {
        private DBContextsDataContext db = new DBContextsDataContext();

        // GET: Admin/DanhMucs
        public ActionResult Index()
        {
            return View(db.DanhMucs.ToList());
        }

        // GET: Admin/DanhMucs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc danhMuc = db.DanhMucs.First(x => x.Id == id);
            if (danhMuc == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc);
        }

        // GET: Admin/DanhMucs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DanhMucs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public string Create([Bind(Include = "Id,Name,Content")] DanhMuc danhMuc, HttpPostedFileBase picture)
        {
            string pictures = "";

            for (int i = 0; i < Request.Files.Count; i++)
            {
                // lấy ra từng file
                picture = Request.Files[i];
                // lấy tên file
                string fileName = picture.FileName;
                // lưu file
                picture.SaveAs(Server.MapPath(@"~/FileUpload/") + fileName);
                pictures += "/FileUpload/" + fileName + ";";
            }
            //add nội dung
            danhMuc.Img = pictures;
            if (ModelState.IsValid)
            {
                db.DanhMucs.InsertOnSubmit(danhMuc);
                db.SubmitChanges();
                return "error";
            }

            return "success";
        }

        // GET: Admin/DanhMucs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc danhMuc = db.DanhMucs.First(x => x.Id == id);
            if (danhMuc == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc);
        }

        // POST: Admin/DanhMucs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name,Content")] DanhMuc danhMuc, HttpPostedFileBase picture)
        {
            DanhMuc danhMucs = db.DanhMucs.First(x => x.Id == danhMuc.Id);
            string pictures = "";
            if (picture != null)
            {

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    // lấy ra từng file
                    picture = Request.Files[i];
                    // lấy tên file
                    string fileName = picture.FileName;
                    // lưu file
                    picture.SaveAs(Server.MapPath(@"~/FileUpload/") + fileName);
                    pictures += "/FileUpload/" + fileName + ";";

                }

            }
            else
            {
                pictures = danhMucs.Img;
            }
            if (ModelState.IsValid)
            {
                if (danhMucs == null)
                {
                    return HttpNotFound();
                }
                danhMucs.Name = danhMuc.Name;
                danhMucs.Img = pictures;
                danhMucs.Content = danhMuc.Content;


                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View(danhMuc);
        }

        // GET: Admin/DanhMucs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc danhMuc = db.DanhMucs.First(x => x.Id == id);
            if (danhMuc == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc);
        }

        // POST: Admin/DanhMucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                DanhMuc danhMuc = db.DanhMucs.First(x => x.Id == id);
                db.DanhMucs.DeleteOnSubmit(danhMuc);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
               catch (Exception)
            {

                TempData["msg"] = "<script>alert('danh mục này chứa danh mục con');</script>";
                return View();
            }
        
          
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
