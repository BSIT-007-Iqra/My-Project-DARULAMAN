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
    public class tbl_InstituteController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Institute
        public ActionResult Index()
        {
            return View(db.tbl_Institute.ToList());
        }

        // GET: tbl_Institute/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Institute tbl_Institute = db.tbl_Institute.Find(id);
            if (tbl_Institute == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Institute);
        }

        // GET: tbl_Institute/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Institute/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "INSTITUTE_ID,INSTITUTE_EMAIL,INSTITUTE_CONTACT")] tbl_Institute tbl_Institute)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Institute.Add(tbl_Institute);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Institute);
        }

        // GET: tbl_Institute/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Institute tbl_Institute = db.tbl_Institute.Find(id);
            if (tbl_Institute == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Institute);
        }

        // POST: tbl_Institute/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "INSTITUTE_ID,INSTITUTE_EMAIL,INSTITUTE_CONTACT")] tbl_Institute tbl_Institute)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Institute).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Institute);
        }

        // GET: tbl_Institute/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Institute tbl_Institute = db.tbl_Institute.Find(id);
            if (tbl_Institute == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Institute);
        }

        // POST: tbl_Institute/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Institute tbl_Institute = db.tbl_Institute.Find(id);
            db.tbl_Institute.Remove(tbl_Institute);
            db.SaveChanges();
            return RedirectToAction("Index");
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
