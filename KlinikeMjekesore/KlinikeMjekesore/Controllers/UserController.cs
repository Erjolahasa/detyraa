using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using KlinikeMjekesore.Models;
using KlinikeMjekesore.Models.extended;

namespace KlinikeMjekesore.Controllers
{
    public class UserController : Controller
    {
        //Reistration Action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        //Registrion Post action 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude = "IsEmailVerified,ActivationCode")] Table User)
        {
            bool status = false;
            string message = "";

            //Model validation
            if (ModelState.IsValid)
            {
                #region//Email is already Exist
                var isExist = IsEmailExist(User.Email);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist");
                    return View(User);
                }
                #endregion

                #region Generate Activation Code
                User.ActivationCode = Guid.NewGuid();

                #endregion

                #region Password Hashing
                User.Password = Passw.Hash(User.Password);
                
                    



                #endregion


                User.IsEmailVerified = false;

                #region Save to Database
                using (MyDatabaseEntities dc = new MyDatabaseEntities())
                {
                    dc.Tables.Add(User);
                    dc.SaveChanges();


                    //send email to user
                    SendVerificationLinkEmail(User.Email, User.ActivationCode.ToString());
                    message = "Registration seccessfully done.Account activation link" + "has been sent to your email Id :"+User.Email;
                    status = true;
                }
                #endregion
            }

            else
            {
                message = "Invalid Request";
            }
            ViewBag.Message = message;
            ViewBag.Status = status;



                return View(User);
            }
            //verify Email
            //verify email  Link

        [HttpGet]
        public ActionResult VerifyAccount(string Id)
        {
            bool status = false;
            using(MyDatabaseEntities dc=new MyDatabaseEntities())
            {
                dc.Configuration.ValidateOnSaveEnabled = false;
                var v = dc.Tables.Where(a => a.ActivationCode == new Guid(id));
                if (v != null)
                {
                    v.IsEmailVerified = true;
                    dc.SaveChanges();
                    status = true;
                }
                else
                {
                    ViewBag.Message = "invalid Message";
                }
            }
            ViewBag.status = true;

            return View();
        }
            //Log in
            //Log in Post
            // Logout


            [NonAction]
            public bool IsEmailExist(string Email)
            {
                using (MyDatabaseEntities dc = new MyDatabaseEntities())
                {
                    var v = dc.Tables.Where(a => a.Email == Email).FirstOrDefault();
                    return v != null;
                }

                
               



                }
        [NonAction]
        public void SendVerificationLinkEmail(string Email,string ActivationCode)
        {
            var verifyUrl = "/User/verifyAccount/" + ActivationCode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);
            var fromEmail = new MailAddress("dotnetawesome@gmail.com", "dotnet awsome ");
            var toEmail = new MailAddress(Email);
            var fromEmailPassword = "*******"; // Repalce with actual password 
            string subject = "Your Account created";
            string body ="<br/><br/> we are excited to tell you that your Dotnet awsome account is"+ "seccessfully created.please click on the  below link     to verify your account"
          +"<br/><br/><a href='"+ link +"'>"+link+" </ a > ";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)

            };
            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
               
        }
            }
          
           







        
    
}
    



    

      