using KarteleKlinikeP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarteleKlinikeP.Controllers
{
    public class TeDhenatBaze : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var pacientId = (int)Session["PacientiId"];
                var pacienti = Manager.pacientis[pacientId];
                return View(pacienti);
            }
            catch (Exception ex)
            {
                return Redirect("../Index");
            }
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}