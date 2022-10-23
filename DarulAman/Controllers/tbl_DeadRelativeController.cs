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
    public class tbl_DeadRelativeController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_DeadRelative
        public ActionResult Index()
        {
            return View(db.tbl_DeadRelative.ToList());
        }

        // GET: tbl_DeadRelative/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_DeadRelative tbl_DeadRelative = db.tbl_DeadRelative.Find(id);
            if (tbl_DeadRelative == null)
            {
                return HttpNotFound();
            }
            return View(tbl_DeadRelative);
        }

        // GET: tbl_DeadRelative/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_DeadRelative/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FUNERAL_ID,FIRST_NAME,LAST_NAME,CONTACT,EMAIL,RELATION_WITH_DEAD,ID,DATE_OF_FUNERAL,ORIGIN,MESSAGE,CONDITION,DATE")] tbl_DeadRelative tbl_DeadRelative)
        {
            if (ModelState.IsValid)
            {
                db.tbl_DeadRelative.Add(tbl_DeadRelative);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_DeadRelative);
        }

        // GET: tbl_DeadRelative/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_DeadRelative tbl_DeadRelative = db.tbl_DeadRelative.Find(id);
            if (tbl_DeadRelative == null)
            {
                return HttpNotFound();
            }
            return View(tbl_DeadRelative);
        }

        // POST: tbl_DeadRelative/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FUNERAL_ID,FIRST_NAME,LAST_NAME,CONTACT,EMAIL,RELATION_WITH_DEAD,ID,DATE_OF_FUNERAL,ORIGIN,MESSAGE,CONDITION,DATE")] tbl_DeadRelative tbl_DeadRelative)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_DeadRelative).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_DeadRelative);
        }

        // GET: tbl_DeadRelative/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_DeadRelative tbl_DeadRelative = db.tbl_DeadRelative.Find(id);
            if (tbl_DeadRelative == null)
            {
                return HttpNotFound();
            }
            return View(tbl_DeadRelative);
        }

        // POST: tbl_DeadRelative/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_DeadRelative tbl_DeadRelative = db.tbl_DeadRelative.Find(id);
            db.tbl_DeadRelative.Remove(tbl_DeadRelative);
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
