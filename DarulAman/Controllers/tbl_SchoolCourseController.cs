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
    public class tbl_SchoolCourseController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_SchoolCourse
        public ActionResult Index()
        {
            return View(db.tbl_SchoolCourse.ToList());
        }

        // GET: tbl_SchoolCourse/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_SchoolCourse tbl_SchoolCourse = db.tbl_SchoolCourse.Find(id);
            if (tbl_SchoolCourse == null)
            {
                return HttpNotFound();
            }
            return View(tbl_SchoolCourse);
        }

        // GET: tbl_SchoolCourse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_SchoolCourse/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COURSE_ID,COURSE_NAME")] tbl_SchoolCourse tbl_SchoolCourse)
        {
            if (ModelState.IsValid)
            {
                db.tbl_SchoolCourse.Add(tbl_SchoolCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_SchoolCourse);
        }

        // GET: tbl_SchoolCourse/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_SchoolCourse tbl_SchoolCourse = db.tbl_SchoolCourse.Find(id);
            if (tbl_SchoolCourse == null)
            {
                return HttpNotFound();
            }
            return View(tbl_SchoolCourse);
        }

        // POST: tbl_SchoolCourse/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COURSE_ID,COURSE_NAME")] tbl_SchoolCourse tbl_SchoolCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_SchoolCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_SchoolCourse);
        }

        // GET: tbl_SchoolCourse/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_SchoolCourse tbl_SchoolCourse = db.tbl_SchoolCourse.Find(id);
            if (tbl_SchoolCourse == null)
            {
                return HttpNotFound();
            }
            return View(tbl_SchoolCourse);
        }

        // POST: tbl_SchoolCourse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_SchoolCourse tbl_SchoolCourse = db.tbl_SchoolCourse.Find(id);
            db.tbl_SchoolCourse.Remove(tbl_SchoolCourse);
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
