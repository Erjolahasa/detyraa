using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using KarteleKlinikeP;
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

        public ActionResult Regjistrimi()
        {
            ViewBag.Message = "Regjistrimi i Pacientit.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Faqja Juaj e Kontaktit.";

            return View();
        }
        public ActionResult Hyr()


        {
            if (Session["PacientiId"] != null)
            {
                return Redirect("Home");
            }
            else
            {
                string errorMessage = "", SuccessMessage = "";
                if (Request.Form["Emri"] != null && Request.Form["Mbiemri"] != null)
                {
                    try
                    {
                        string Emri = Request.Form["Emri"], Mbiemri = Request.Form["Mbiemri"];
                        if (string.IsNullOrEmpty(Emri))
                        {
                            errorMessage = "Vendos emrin";
                        }
                        else if (string.IsNullOrEmpty(Mbiemri))
                        {
                            errorMessage = "Vendos mbiemrin";
                        }
                        else
                        {
                            foreach (var PacientiId in Manager.pacientis.Keys)
                            {
                                var pacienti = Manager.pacientis[PacientiId];
                                
                                    
                                   
                                {
                                    Session["PacientiId"] = PacientiId;
                                    Session["emri"] = pacienti.Emri;
                                    SuccessMessage = "Hyrja u be me sukses";

                                    return Redirect("../profili");

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMessage = "Ndodhi nje gabim";
                    }
                }
                ViewBag.ErrorMessage = errorMessage;
                return View();
            }
        }


        public ActionResult Details(int id)

        {
            // var pacienti = new Pacienti()
            //{
            //Emri = "erjola",
            //Mbiemri = "hasa",
            //Identifikimi = 1
            //};

            return View(KarteleKlinikeP.Manager.pacientis[id]);
        }
        public ActionResult DetailList()
           

        {
            var list = new List<Pacienti>();
            foreach (var key in Manager.pacientis.Keys)
                list.Add(Manager.pacientis[key]);
            return View(list);
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Dalja()
        {
            Session.Abandon();
            return Redirect("Home");
        
        }
        [HttpGet]
        [HttpPost]
        public ActionResult Create()
        {
            try
            {

            
            var Account = new Account()
            {

                Emri = Request.QueryString["Emri"],
                Mbiemri = Request.QueryString["Mbiemri"],
                Adressa = Request.QueryString["Adresa"],
                Adressa2 = Request.QueryString["Adresa2"],
                ID = int.Parse(Request.QueryString["id"]),
                Qyteti = Request.QueryString["qyteti"],
                Pavioni = Request.QueryString["pavioni"],
                KodiPacientit = Request.QueryString["Kodipacientit"]

            };

            //Manager.accounts.Add(Account.ID, Account);
        }
        catch(Exception ex) { }
                return View();
            }

    }
}




