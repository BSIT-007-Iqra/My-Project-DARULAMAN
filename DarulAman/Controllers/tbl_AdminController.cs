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
    public class tbl_AdminController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Admin
        public ActionResult Index()
        {
            var tbl_Admin = db.tbl_Admin.Include(t => t.tbl_AccessLevel);
            return View(tbl_Admin.ToList());
        }

        // GET: tbl_Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Admin tbl_Admin = db.tbl_Admin.Find(id);
            if (tbl_Admin == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Admin);
        }

        // GET: tbl_Admin/Create
        public ActionResult Create()
        {
            ViewBag.ACCESS_LEVEL_FID = new SelectList(db.tbl_AccessLevel, "ACCESS_LEVEL_ID", "NAME");
            return View();
        }

        // POST: tbl_Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ADMIN_ID,FIRST_NAME,LAST_NAME,EMAIL,CONTACT,PASSWORD,ADDRESS,STATUS,ACCESS_LEVEL_FID")] tbl_Admin tbl_Admin)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Admin.Add(tbl_Admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ACCESS_LEVEL_FID = new SelectList(db.tbl_AccessLevel, "ACCESS_LEVEL_ID", "NAME", tbl_Admin.ACCESS_LEVEL_FID);
            return View(tbl_Admin);
        }

        // GET: tbl_Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Admin tbl_Admin = db.tbl_Admin.Find(id);
            if (tbl_Admin == null)
            {
                return HttpNotFound();
            }
            ViewBag.ACCESS_LEVEL_FID = new SelectList(db.tbl_AccessLevel, "ACCESS_LEVEL_ID", "NAME", tbl_Admin.ACCESS_LEVEL_FID);
            return View(tbl_Admin);
        }

        // POST: tbl_Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ADMIN_ID,FIRST_NAME,LAST_NAME,EMAIL,CONTACT,PASSWORD,ADDRESS,STATUS,ACCESS_LEVEL_FID")] tbl_Admin tbl_Admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ACCESS_LEVEL_FID = new SelectList(db.tbl_AccessLevel, "ACCESS_LEVEL_ID", "NAME", tbl_Admin.ACCESS_LEVEL_FID);
            return View(tbl_Admin);
        }

        // GET: tbl_Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Admin tbl_Admin = db.tbl_Admin.Find(id);
            if (tbl_Admin == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Admin);
        }

        // POST: tbl_Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Admin tbl_Admin = db.tbl_Admin.Find(id);
            db.tbl_Admin.Remove(tbl_Admin);
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
        public ActionResult Profile()
        {
            return View();
        }
    }
}
