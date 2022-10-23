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
    public class tbl_VolunteerController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Volunteer
        public ActionResult Index()
        {
            return View(db.tbl_Volunteer.ToList());
        }

        // GET: tbl_Volunteer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Volunteer tbl_Volunteer = db.tbl_Volunteer.Find(id);
            if (tbl_Volunteer == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Volunteer);
        }

      

        // GET: tbl_Volunteer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Volunteer tbl_Volunteer = db.tbl_Volunteer.Find(id);
            if (tbl_Volunteer == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Volunteer);
        }

        // POST: tbl_Volunteer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VOLUNTEER_ID,FIRST_NAME,LAST_NAME,EMAIL,ID,REASON,DATE,STATUS")] tbl_Volunteer tbl_Volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Volunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Volunteer);
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
