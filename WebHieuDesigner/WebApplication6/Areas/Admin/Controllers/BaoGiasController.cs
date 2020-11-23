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
    public class BaoGiasController : Controller
    {
        private DBContextsDataContext db = new DBContextsDataContext();

        // GET: Admin/BaoGias
        public ActionResult Index()
        {
            var baoGias = db.BaoGias.Include(b => b.Item);
            return View(baoGias.ToList());
        }

        // GET: Admin/BaoGias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaoGia baoGia = db.BaoGias.First(x => x.Id == id);
            if (baoGia == null)
            {
                return HttpNotFound();
            }
            return View(baoGia);
        }

        // GET: Admin/BaoGias/Create
        public ActionResult Create()
        {
            ViewBag.itemID = new SelectList(db.Items, "Id", "Tile");
            return View();
        }

        // POST: Admin/BaoGias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HotenKH,Email,SoDienThoai,Images,itemID")] BaoGia baoGia)
        {
            if (ModelState.IsValid)
            {
                db.BaoGias.InsertOnSubmit(baoGia);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }

            ViewBag.itemID = new SelectList(db.Items, "Id", "Tile", baoGia.itemID);
            return View(baoGia);
        }

        // GET: Admin/BaoGias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaoGia baoGia = db.BaoGias.First(x => x.Id == id);
            if (baoGia == null)
            {
                return HttpNotFound();
            }
            List<Status> lstInt = new List<Status>()
            {
                new Status()
                {
                    id =0,
                    name="Chưa xử lý"
                },
                 new Status()
                {
                    id =1,
                    name="Đã xử lý"
                }
            };
       
            ViewBag.Images = new SelectList(lstInt, "Id", "name", baoGia.Images);
            ViewBag.itemID = new SelectList(db.Items, "Id", "Tile", baoGia.itemID);
            return View(baoGia);
        }

        // POST: Admin/BaoGias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HotenKH,Email,SoDienThoai,Images,itemID")] BaoGia baoGia)
        {
            if (ModelState.IsValid)
            {
                BaoGia baoGias = db.BaoGias.First(x => x.Id == baoGia.Id);
                if (baoGia == null)
                {
                    return HttpNotFound();
                }
                baoGias.Images = baoGia.Images;
                baoGias.itemID = baoGia.itemID;
                baoGias.HotenKH = baoGia.HotenKH;
                baoGias.Email = baoGia.Email;
                baoGias.SoDienThoai = baoGia.SoDienThoai;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            ViewBag.itemID = new SelectList(db.Items, "Id", "Tile", baoGia.itemID);
            return View(baoGia);
        }

        // GET: Admin/BaoGias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaoGia baoGia = db.BaoGias.First(x => x.Id == id);
            if (baoGia == null)
            {
                return HttpNotFound();
            }
            return View(baoGia);
        }

        // POST: Admin/BaoGias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BaoGia baoGia = db.BaoGias.First(x => x.Id == id);
            db.BaoGias.DeleteOnSubmit(baoGia);
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
    public class Status
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
