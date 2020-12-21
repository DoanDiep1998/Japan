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
    public class BanersController : Controller
    {
        private DBContextsDataContext db = new DBContextsDataContext();

        // GET: Admin/Baners
        public ActionResult Index()
        {
    
            return View(db.Baners.ToList());
            
        }

        // GET: Admin/Baners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baner baner = db.Baners.First(x=>x.id == id);
            if (baner == null)
            {
                return HttpNotFound();
            }
            return View(baner);
        }

        // GET: Admin/Baners/Create
        public ActionResult Create()
        {
            ViewBag.ID_Item = new SelectList(db.Items, "Id", "Tile");
            return View();
        }

        // POST: Admin/Baners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "id,name,location,Images,ID_Item")] Baner baner, HttpPostedFileBase picture)
        {
            ViewBag.ID_Item = new SelectList(db.Items, "Id", "Tile");
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
            baner.Images = pictures;
            if (ModelState.IsValid)
            {
                db.Baners.InsertOnSubmit(baner);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }

            return View(baner);
        }

        // GET: Admin/Baners/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.ID_Item = new SelectList(db.Items, "Id", "Tile");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baner baner = db.Baners.First(x => x.id == id); 
            if (baner == null)
            {
                return HttpNotFound();
            }
            return View(baner);
        }

        // POST: Admin/Baners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,name,location,Images,ID_Item")] Baner baner, HttpPostedFileBase picture)
        {
            ViewBag.ID_Item = new SelectList(db.Items, "Id", "Tile");
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
                    picture.SaveAs(Server.MapPath(@"~/Content/FileUpload/") + fileName);
                    pictures += "/Content/FileUpload/" + fileName + ";";

                }

            }
            else
            {
                pictures = baner.Images;
            }
            if (ModelState.IsValid)
            {
                Baner baners = db.Baners.First(x => x.id == baner.id);
                if (baner == null)
                {
                    return HttpNotFound();
                }
                baners.Images = pictures;
                baners.location = baner.location;
                baners.name = baner.name;
                baners.id_Item = baner.id_Item;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View(baner);
        }

        // GET: Admin/Baners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baner baner = db.Baners.First(x => x.id == id);
            if (baner == null)
            {
                return HttpNotFound();
            }
            return View(baner);
        }

        // POST: Admin/Baners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Baner baner = db.Baners.First(x => x.id == id);
            db.Baners.DeleteOnSubmit(baner);
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
