
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        private DBContextsDataContext db = new DBContextsDataContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userName, string pass)
        {
            var user = db.Admins.FirstOrDefault(x => x.UserName == userName && x.Pass == pass);
            if (user !=null)
            {
                Session["UserId"] = user.UserName;
                return RedirectToAction("Index", "Items");
            }
            return View();
        }

    }
}