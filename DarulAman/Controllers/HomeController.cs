using DarulAman.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DarulAman.Utills;

namespace DarulAman.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult IndexAdmin()
        {
            return View();
        }

        public ActionResult IndexCustomer()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }
        public ActionResult About()
        {
           
            return View();
        }
        public ActionResult Slider()
        {
            return View(db.tbl_Slider.ToList());
           
        }
        public ActionResult Donate()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Donate(tbl_Donation donation)
        {
            if (ModelState.IsValid)
            {
                donation.DATE = System.DateTime.Now;
                db.tbl_Donation.Add(donation);
                db.SaveChanges();
                //ViewBag.message = "Your Request has been delivered Successfully";
            } 
  string mailBody = "Your request has been delivered";
            EmailProvider.Email(donation.EMAIL, "CONFIRMATION MESSAGE!",mailBody);
            return View();
        }

        public ActionResult Team()
        {

            return View(db.tbl_Team.ToList());
        }  
        public ActionResult Event(int? id)
        {

            return View();
        } 
        public ActionResult Teaching()
        {

            return View();
        }
       
[HttpPost]
        public ActionResult Teaching(tbl_TeachingRegistration t)
        {
            if (ModelState.IsValid)
            {
                t.DATE = System.DateTime.Now;
                db.tbl_TeachingRegistration.Add(t);
                db.SaveChanges();  
            }
   string mailBody = "Your request has been delivered";
            EmailProvider.Email(t.EMAIL, "CONFIRMATION MESSAGE!",mailBody);
            return RedirectToAction("Confirmation");
        }
        public ActionResult Confirmation()
        {          
            return View();
        }
        public ActionResult Marriage()
        {

            return View();
        }
      [HttpPost]
        public ActionResult Marriage(tbl_Marriage marriage)
        {
            if (ModelState.IsValid)
            {
                marriage.DATE = System.DateTime.Now;
                db.tbl_Marriage.Add(marriage);
                db.SaveChanges();
                ViewBag.message = "Your Request has been delivered";
            }
            string mailBody = "Your request has been delivered";
            EmailProvider.Email(marriage.EMAIL, "CONFIRMATION MESSAGE!",mailBody);
            return View();
        }
       
        public ActionResult DeadRelative()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DeadRelative(tbl_DeadRelative DeadRelative)
        {
            if (ModelState.IsValid)

            {
                DeadRelative.DATE = System.DateTime.Now;
                db.tbl_DeadRelative.Add(DeadRelative);
                db.SaveChanges();

                var max = db.tbl_DeadRelative.Max(x => x.FUNERAL_ID);
                //Max Means to Fetch LastID in the Current Table
                return Redirect("/Home/Decreased/" + max);
            }
            string mailBody = "Your request has been delivered";
            EmailProvider.Email(DeadRelative.EMAIL, "CONFIRMATION MESSAGE!", mailBody);
            return View();
        }
        public ActionResult Decreased(int id)
        {
            ViewBag.LastID = id;
            return View();
        }
        [HttpPost]
        public ActionResult Decreased(tbl_Decreased d)
        {
                if (ModelState.IsValid)
            {
                d.DATE = System.DateTime.Now;
                db.tbl_Decreased.Add(d);
                db.SaveChanges();
               }

            return View();
        }

    public ActionResult School()
        {

            return View();
        }

        [HttpPost]
        public ActionResult School(tbl_SchoolRegistration s)
        {
            if (ModelState.IsValid)
            {
                s.DATE = System.DateTime.Now;
                db.tbl_SchoolRegistration.Add(s);
                db.SaveChanges();
            }
            string mailBody = "Your request has been delivered";
            EmailProvider.Email(s.EMAIL, "CONFIRMATION MESSAGE!", mailBody);
            return RedirectToAction("Confirmation");
        }
        [HttpPost]
        
        public ActionResult Prayer()
        {

            return View();
        } 
        public ActionResult Volunteer()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Volunteer(tbl_Volunteer v)
        {
            if (ModelState.IsValid)
            {
                v.DATE = System.DateTime.Now;
                db.tbl_Volunteer.Add(v);
                db.SaveChanges();
            }
            string mailBody = "Your request has been delivered";
            EmailProvider.Email(v.EMAIL, "CONFIRMATION MESSAGE!", mailBody);
            return RedirectToAction("Confirmation");
        }
        public ActionResult Mosque()
        {

            return View();
        } 
        public ActionResult Library()
        {

            return View();
        }
        public ActionResult GeneralRegistration()
        {

            return View();
        }  
        public ActionResult Translation()
        {

            return View();
        }
        public ActionResult Gym()
        {

            return View();
        }
        public ActionResult Slaughterhouse()
        {

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(tbl_Admin a)
        {

            var check = db.tbl_Admin.Where(x => x.EMAIL == a.EMAIL && x.PASSWORD == a.PASSWORD).FirstOrDefault();
            if (check != null)
            {
                if (check.ACCESS_LEVEL_FID == 1 && check.STATUS == "Active")
                {
                    BaseHelper.Currentmember = check;
                    return RedirectToAction("IndexAdmin", "Home");
                }
                else if (check.ACCESS_LEVEL_FID == 2 && check.STATUS == "Active")
                {
                    BaseHelper.Currentdonation = check;
                    return RedirectToAction("Index", "tbl_Donation");
                }
              
                else if (check.ACCESS_LEVEL_FID == 3 && check.STATUS == "Active")
                {
                    BaseHelper.Currentmarriage = check;
                    return RedirectToAction("Index", "tbl_Volunteer");
                }
                else if (check.ACCESS_LEVEL_FID == 4 && check.STATUS == "Active")
                {
                    BaseHelper.Currentteachingquran = check;
                    return RedirectToAction("Index", "tbl_Marriage");
                }
                else if (check.ACCESS_LEVEL_FID == 5 && check.STATUS == "Active")
                {
                    BaseHelper.Currentfuneral = check;
                    return RedirectToAction("Index", "tbl_TeachingRegistration");
                }  
                else if (check.ACCESS_LEVEL_FID == 6 && check.STATUS == "Active")
                {
                    BaseHelper.Currentfuneral = check;
                    return RedirectToAction("Index", "tbl_SchoolRegistration");
                } 
              
                else if (check.ACCESS_LEVEL_FID == 7 && check.STATUS == "Active")
                {
                    BaseHelper.Currentfuneral = check;
                    return RedirectToAction("GeneralRegistration", "AdminSideForm");
                } 
                else if (check.ACCESS_LEVEL_FID == 8 && check.STATUS == "Active")
                {
                    BaseHelper.Currentfuneral = check;
                    return RedirectToAction("Index", "tbl_DeadRelative");
                }
                else
                {
                    ViewBag.Message = "Your Account has not been active anymore. Please contact Admin!";
                    return View();
                }
            }

            else
            {
                ViewBag.Message = "Invalid Email & Password";
                return View();
            }


        }
         public ActionResult Newpassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Newpassword(string newPassword)
        {
            var pass = (tbl_Admin)Session["ForgetPassword"];
            var v = db.tbl_Admin.Where(x => x.EMAIL == pass.EMAIL).FirstOrDefault();
            v.PASSWORD = newPassword;
            db.Entry(v).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Message"] = "Password Updated Successfully";
            return RedirectToAction("Login");

        }
        public ActionResult CodeVerify()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CodeVerify(int? code)
        {
            int sendCode = (int)Session["code"];
            if (code == sendCode)
            {
                return RedirectToAction("Newpassword");
            }
            TempData["message"] = "Invalid Email";
            return View();
        }

        

        
   
        public ActionResult PrivacyPolicy()
        {
            return View();
        } 
        public ActionResult Termsofuse()
        {
            return View();
        }
     
       
        [HttpPost]
        public ActionResult SubmitContact(tbl_Contact c)
        {
            if (ModelState.IsValid)
            {

                c.DATE = System.DateTime.Now;
                db.tbl_Contact.Add(c);
                db.SaveChanges();
                ViewBag.message = "Your Request has been delivered";
            }
            string mailBody = "Your request has been delivered";
            EmailProvider.Email(c.EMAIL, "CONFIRMATION MESSAGE!", mailBody);
            return RedirectToAction("IndexCustomer");
        }


         public ActionResult FAQs()
        {
            return View (db.tbl_FAQs.ToList());
           
       }
    }
}