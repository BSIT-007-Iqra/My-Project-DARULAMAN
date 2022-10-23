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
    public class tbl_TeachingRegistrationController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_TeachingRegistration
        public ActionResult Index()
        {
            return View(db.tbl_TeachingRegistration.ToList());
        }

        // GET: tbl_TeachingRegistration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_TeachingRegistration tbl_TeachingRegistration = db.tbl_TeachingRegistration.Find(id);
            if (tbl_TeachingRegistration == null)
            {
                return HttpNotFound();
            }
            return View(tbl_TeachingRegistration);
        }

        // GET: tbl_TeachingRegistration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_TeachingRegistration tbl_TeachingRegistration = db.tbl_TeachingRegistration.Find(id);
            if (tbl_TeachingRegistration == null)
            {
                return HttpNotFound();
            }
            return View(tbl_TeachingRegistration);
        }

        // POST: tbl_TeachingRegistration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TEACHING_ID,FIRST_NAME,LAST_NAME,CONTACT,EMAIL,ID,GENDER,ORIGIN,ADDRESS,GUARDIAN,COURSE,MESSAGE,DATE")] tbl_TeachingRegistration tbl_TeachingRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_TeachingRegistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_TeachingRegistration);
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
