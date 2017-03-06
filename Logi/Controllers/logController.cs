using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logi.Controllers
{
    public class logController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index1(string User, string Password)
        {
            Models.RoadsEntities obj = new Models.RoadsEntities();
            var user = obj.tblUsers.Where(m => m.UserName == User && m.Password == Password).FirstOrDefault();
            if(user == null)
            {
                ViewBag.error = "input again";
                return View("Index");
            }
                else
            {
                return View("View1");
            }

        }

    }
}