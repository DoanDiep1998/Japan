using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;


namespace WebApplication6.Areas.Admin.Controllers
{
    public class DanhMucConsController : Controller
    {
        private DBContextsDataContext db = new DBContextsDataContext();

        // GET: Admin/DanhMucCons
        public ActionResult Index()
        {
            return View(db.DanhMucCons.ToList());
        }

        // GET: Admin/DanhMucCons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucCon danhMucCon = db.DanhMucCons.First(x => x.Id == id);
            if (danhMucCon == null)
            {
                return HttpNotFound();
            }
            return View(danhMucCon);
        }

        // GET: Admin/DanhMucCons/Create
        public ActionResult Create()
        {
            ViewBag.danhmucID = new SelectList(db.DanhMucs, "Id", "Name");
         
            return View();
        }

        // POST: Admin/DanhMucCons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ID_DanhMucCha")] DanhMucCon danhMucCon)
        {
            if (ModelState.IsValid)
            {
                db.DanhMucCons.InsertOnSubmit(danhMucCon);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            ViewBag.danhmucID = new SelectList(db.DanhMucs, "Id", "Name", danhMucCon.ID_DanhMucCha);
            return View(danhMucCon);
        }

        // GET: Admin/DanhMucCons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucCon danhMucCon = db.DanhMucCons.First(x => x.Id == id);
            if (danhMucCon == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_DanhMucCha = new SelectList(db.DanhMucs, "Id", "Name", danhMucCon.ID_DanhMucCha);
            return View(danhMucCon);
        }

        // POST: Admin/DanhMucCons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ID_DanhMucCha")] DanhMucCon danhMucCon)
        {
            if (ModelState.IsValid)
            {
                DanhMucCon danhMucCon2 = db.DanhMucCons.First(x => x.Id == danhMucCon.Id);
                if (danhMucCon2 == null)
                {
                    return HttpNotFound();
                }
                danhMucCon2.Name = danhMucCon.Name;
                danhMucCon2.ID_DanhMucCha = danhMucCon.ID_DanhMucCha;
                db.SubmitChanges();
                ViewBag.ID_DanhMucCha = new SelectList(db.DanhMucs, "Id", "Name", danhMucCon.ID_DanhMucCha);
                return RedirectToAction("Index");
            }
           
            return View(danhMucCon);
        }

        // GET: Admin/DanhMucCons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucCon danhMucCon = db.DanhMucCons.First(x => x.Id == id);
            if (danhMucCon == null)
            {
                return HttpNotFound();
            }
            return View(danhMucCon);
        }

        // POST: Admin/DanhMucCons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DanhMucCon danhMucCon = db.DanhMucCons.First(x => x.Id == id);
            db.DanhMucCons.DeleteOnSubmit(danhMucCon);
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
