using DarulAman.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DarulAman.Controllers
{
    public class AdminSideFormController : Controller
    {
        Model1 db = new Model1();
   
        public ActionResult GeneralRegistration()
        {
            var g = db.tbl_GeneralRegistrationForm.ToList();
            return View(g);
        }  
       
        public ActionResult ContactRegistration()
        {
            var c = db.tbl_Contact.ToList();
            return View(c);
        }   
      
       
       
    }
}