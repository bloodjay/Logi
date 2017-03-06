using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logi.Controllers
{
    public class machineController : Controller
    {
        // GET: machine
        public ActionResult Index()
        {
            Models.RoadsEntities obj = new Models.RoadsEntities();
            var mach = obj.tblMaches.FirstOrDefault();
            var owner = obj.tblOwners.ToList();
            ViewBag.ItemsSelect = new SelectList (owner, "Owner_Num","Owner_Name");

            return View("Index");
        }
        [HttpPost]
        public ActionResult mach(Models.tblMach mach)
        {
            Models.RoadsEntities obj = new Models.RoadsEntities();
            var mac = obj.tblMaches.ToList();  
                   
            obj.tblMaches.Add(mach);
            obj.SaveChanges();
            var owner = obj.tblOwners.ToList();
            return View("Index");
        }


        public ActionResult gridindex()
        {
            Models.RoadsEntities obj = new Models.RoadsEntities();
            var mac = obj.tblMaches.ToList();
            return View(mac);
        }

        public ActionResult updat()
        {
            Models.RoadsEntities obj = new Models.RoadsEntities();
            var mac = obj.tblMaches.ToList();
            var owner = obj.tblOwners.ToList();
            ViewBag.ItemsSelect = new SelectList(owner, "Owner_Num", "Owner_Name");
            return View("index");
        }

        public ActionResult editt(int? a)
        {
            Models.RoadsEntities obj = new Models.RoadsEntities();
            var owner = obj.tblOwners.ToList();
            ViewBag.ItemsSelect = new SelectList(owner, "Owner_Num", "Owner_Name");
            var mac = obj.tblMaches.Where(m => m.Mach_No == a).FirstOrDefault();
            return View("Index",mac);
        }       
    }
}