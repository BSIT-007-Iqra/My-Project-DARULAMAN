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
    public class tbl_MarriageController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Marriage
        public ActionResult Index()
        {
            return View(db.tbl_Marriage.ToList());
        }

        // GET: tbl_Marriage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Marriage tbl_Marriage = db.tbl_Marriage.Find(id);
            if (tbl_Marriage == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Marriage);
        }

       

        // GET: tbl_Marriage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Marriage tbl_Marriage = db.tbl_Marriage.Find(id);
            if (tbl_Marriage == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Marriage);
        }

        // POST: tbl_Marriage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MARRIAGE_ID,FIRST_NAME,LAST_NAME,CONTACT,EMAIL,ID,DATE_OF_MARRIAGE,ORIGIN,MESSAGE,DATE,STATUS")] tbl_Marriage tbl_Marriage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Marriage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Marriage);
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
