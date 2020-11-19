using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private DBContextsDataContext db = new DBContextsDataContext();
        public ActionResult Index()
        {
            var lstBanner = db.Baners.ToList();
            ViewBag.lstBanner1 = lstBanner.Where(x => x.location == 1);
            ViewBag.totalBanner1 = lstBanner.Where(x => x.location == 1).ToList().Count;
            ViewBag.lstBanner2 = lstBanner.Where(x => x.location == 2);

            var lstDanhMuc = db.DanhMucs.ToList();
            ViewBag.lstDanhMuc = lstDanhMuc;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}