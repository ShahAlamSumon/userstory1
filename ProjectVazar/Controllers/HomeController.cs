using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectVazar.Models;

namespace ProjectVazar.Controllers
{
    public class HomeController : Controller
    {
        ProjectVazarDB db = new ProjectVazarDB();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveDepartment(string selname, string selemail, string selpass, int selphone)
        {
            User aUser = new User() { FullName = selname, Email = selemail, Password = selpass, MobileNo = selphone, Role = "Seller" };
            db.Users.Add(aUser);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
	}
}