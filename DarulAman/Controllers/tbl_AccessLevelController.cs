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
    public class tbl_AccessLevelController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_AccessLevel
        public ActionResult Index()
        {
            return View(db.tbl_AccessLevel.ToList());
        }

        // GET: tbl_AccessLevel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_AccessLevel tbl_AccessLevel = db.tbl_AccessLevel.Find(id);
            if (tbl_AccessLevel == null)
            {
                return HttpNotFound();
            }
            return View(tbl_AccessLevel);
        }

        // GET: tbl_AccessLevel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_AccessLevel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ACCESS_LEVEL_ID,NAME")] tbl_AccessLevel tbl_AccessLevel)
        {
            if (ModelState.IsValid)
            {
                db.tbl_AccessLevel.Add(tbl_AccessLevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_AccessLevel);
        }

        // GET: tbl_AccessLevel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_AccessLevel tbl_AccessLevel = db.tbl_AccessLevel.Find(id);
            if (tbl_AccessLevel == null)
            {
                return HttpNotFound();
            }
            return View(tbl_AccessLevel);
        }

        // POST: tbl_AccessLevel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ACCESS_LEVEL_ID,NAME")] tbl_AccessLevel tbl_AccessLevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_AccessLevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_AccessLevel);
        }

        // GET: tbl_AccessLevel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_AccessLevel tbl_AccessLevel = db.tbl_AccessLevel.Find(id);
            if (tbl_AccessLevel == null)
            {
                return HttpNotFound();
            }
            return View(tbl_AccessLevel);
        }

        // POST: tbl_AccessLevel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_AccessLevel tbl_AccessLevel = db.tbl_AccessLevel.Find(id);
            db.tbl_AccessLevel.Remove(tbl_AccessLevel);
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
