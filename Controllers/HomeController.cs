using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mobile_Affordability_Application.Models;
using System.Web.Script.Serialization;

namespace Mobile_App.Controllers
{
    public class HomeController : Controller
    {
        private MobileDBEntities db = new MobileDBEntities();


        public ActionResult Index()
        {
            MobileDBEntities sd = new MobileDBEntities();
            ViewBag.Mobiles = new SelectList(sd.Mobiles, "MobileType", "MobileCost");
            Mobile mobi = new Mobile();

            
          mobi.MobileCollection = db.Mobiles.ToList<Mobile>();

           
            return View(mobi);
        }

        

        public ActionResult Index3()
        {
            Mobile Mobi = new Mobile();

            using (MobileDBEntities db = new MobileDBEntities())
            {
                Mobi.MobileCollection = db.Mobiles.ToList<Mobile>();

            }

            return View(Mobi);
        }

        

    }
}


