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
    public class tbl_TeachingCourseController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_TeachingCourse
        public ActionResult Index()
        {
            return View(db.tbl_TeachingCourse.ToList());
        }

        // GET: tbl_TeachingCourse/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_TeachingCourse tbl_TeachingCourse = db.tbl_TeachingCourse.Find(id);
            if (tbl_TeachingCourse == null)
            {
                return HttpNotFound();
            }
            return View(tbl_TeachingCourse);
        }

        // GET: tbl_TeachingCourse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_TeachingCourse/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COURSE_ID,COURSE_NAME")] tbl_TeachingCourse tbl_TeachingCourse)
        {
            if (ModelState.IsValid)
            {
                db.tbl_TeachingCourse.Add(tbl_TeachingCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_TeachingCourse);
        }

        // GET: tbl_TeachingCourse/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_TeachingCourse tbl_TeachingCourse = db.tbl_TeachingCourse.Find(id);
            if (tbl_TeachingCourse == null)
            {
                return HttpNotFound();
            }
            return View(tbl_TeachingCourse);
        }

        // POST: tbl_TeachingCourse/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COURSE_ID,COURSE_NAME")] tbl_TeachingCourse tbl_TeachingCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_TeachingCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_TeachingCourse);
        }

        // GET: tbl_TeachingCourse/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_TeachingCourse tbl_TeachingCourse = db.tbl_TeachingCourse.Find(id);
            if (tbl_TeachingCourse == null)
            {
                return HttpNotFound();
            }
            return View(tbl_TeachingCourse);
        }

        // POST: tbl_TeachingCourse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_TeachingCourse tbl_TeachingCourse = db.tbl_TeachingCourse.Find(id);
            db.tbl_TeachingCourse.Remove(tbl_TeachingCourse);
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
