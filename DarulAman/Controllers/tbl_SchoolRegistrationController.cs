using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DarulAman.Models;

namespace DarulAman.Controllers
{
    public class tbl_SchoolRegistrationController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_SchoolRegistration
        public ActionResult Index()
        {
            return View(db.tbl_SchoolRegistration.ToList());
        }

        // GET: tbl_SchoolRegistration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_SchoolRegistration tbl_SchoolRegistration = db.tbl_SchoolRegistration.Find(id);
            if (tbl_SchoolRegistration == null)
            {
                return HttpNotFound();
            }
            return View(tbl_SchoolRegistration);
        }

      

        // GET: tbl_SchoolRegistration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_SchoolRegistration tbl_SchoolRegistration = db.tbl_SchoolRegistration.Find(id);
            if (tbl_SchoolRegistration == null)
            {
                return HttpNotFound();
            }
            return View(tbl_SchoolRegistration);
        }

        // POST: tbl_SchoolRegistration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SCHOOL_ID,FIRST_NAME,LAST_NAME,CONTACT,EMAIL,ID,GENDER,ORIGIN,ADDRESS,GUARDIAN,COURSE,MESSAGE,DATE")] tbl_SchoolRegistration tbl_SchoolRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_SchoolRegistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_SchoolRegistration);
        }

       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
