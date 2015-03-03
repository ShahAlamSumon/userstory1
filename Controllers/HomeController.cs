using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
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

        public JsonResult SaveDepartment(string selname, string selemail, string selpass, string selphone, string selrole)
        {
            User aUser = new User() { FullName = selname, Email = selemail, Password = selpass, MobileNo = selphone, Role = selrole };
            db.Users.Add(aUser);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
       

        public JsonResult ValidateUser(string email, string password)
        {
           
            if (db.Users.FirstOrDefault(a=>a.Email==email && a.Password==password)!=null)
            {

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }

    }


}