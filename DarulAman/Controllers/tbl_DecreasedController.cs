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
    public class tbl_DecreasedController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Decreased
        public ActionResult Index()
        {
            var tbl_Decreased = db.tbl_Decreased.Include(t => t.tbl_DeadRelative);
            return View(tbl_Decreased.ToList());
        }

        // GET: tbl_Decreased/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Decreased tbl_Decreased = db.tbl_Decreased.Find(id);
            if (tbl_Decreased == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Decreased);
        }

        // GET: tbl_Decreased/Create
        public ActionResult Create()
        {
            ViewBag.FUNERAL_FID = new SelectList(db.tbl_DeadRelative, "FUNERAL_ID", "FIRST_NAME");
            return View();
        }

        // POST: tbl_Decreased/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DECREASED_ID,FIRST_NAME,LAST_NAME,AGE,GENDER,DATE_OF_DEATH,STATUS,DATE,FUNERAL_FID")] tbl_Decreased tbl_Decreased)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Decreased.Add(tbl_Decreased);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FUNERAL_FID = new SelectList(db.tbl_DeadRelative, "FUNERAL_ID", "FIRST_NAME", tbl_Decreased.FUNERAL_FID);
            return View(tbl_Decreased);
        }

        // GET: tbl_Decreased/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Decreased tbl_Decreased = db.tbl_Decreased.Find(id);
            if (tbl_Decreased == null)
            {
                return HttpNotFound();
            }
            ViewBag.FUNERAL_FID = new SelectList(db.tbl_DeadRelative, "FUNERAL_ID", "FIRST_NAME", tbl_Decreased.FUNERAL_FID);
            return View(tbl_Decreased);
        }

        // POST: tbl_Decreased/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DECREASED_ID,FIRST_NAME,LAST_NAME,AGE,GENDER,DATE_OF_DEATH,STATUS,DATE,FUNERAL_FID")] tbl_Decreased tbl_Decreased)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Decreased).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FUNERAL_FID = new SelectList(db.tbl_DeadRelative, "FUNERAL_ID", "FIRST_NAME", tbl_Decreased.FUNERAL_FID);
            return View(tbl_Decreased);
        }

        // GET: tbl_Decreased/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Decreased tbl_Decreased = db.tbl_Decreased.Find(id);
            if (tbl_Decreased == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Decreased);
        }

        // POST: tbl_Decreased/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Decreased tbl_Decreased = db.tbl_Decreased.Find(id);
            db.tbl_Decreased.Remove(tbl_Decreased);
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
