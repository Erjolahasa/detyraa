using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KarteleKlinikeP.Controllers;
using KarteleKlinikeP.Models;

namespace KarteleKlinikeP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Regjistrimi()
        {
            ViewBag.Message = "Regjistrimi i Pacientit.";
            return View(new object());
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Faqja Juaj e Kontaktit.";

            return View();
        }
       public  ActionResult Hyrja()
        {
            ViewBag.Massage = "hyrja e pacientiti";
            return View();
        }
        
}
}