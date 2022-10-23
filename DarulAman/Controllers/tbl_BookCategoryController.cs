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
    public class tbl_BookCategoryController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_BookCategory
        public ActionResult Index()
        {
            return View(db.tbl_BookCategory.ToList());
        }

        // GET: tbl_BookCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_BookCategory tbl_BookCategory = db.tbl_BookCategory.Find(id);
            if (tbl_BookCategory == null)
            {
                return HttpNotFound();
            }
            return View(tbl_BookCategory);
        }

        // GET: tbl_BookCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_BookCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CATEGORY_ID,CATEGORY_NAME")] tbl_BookCategory tbl_BookCategory)
        {
            if (ModelState.IsValid)
            {
                db.tbl_BookCategory.Add(tbl_BookCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_BookCategory);
        }

        // GET: tbl_BookCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_BookCategory tbl_BookCategory = db.tbl_BookCategory.Find(id);
            if (tbl_BookCategory == null)
            {
                return HttpNotFound();
            }
            return View(tbl_BookCategory);
        }

        // POST: tbl_BookCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CATEGORY_ID,CATEGORY_NAME")] tbl_BookCategory tbl_BookCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_BookCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_BookCategory);
        }

        // GET: tbl_BookCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_BookCategory tbl_BookCategory = db.tbl_BookCategory.Find(id);
            if (tbl_BookCategory == null)
            {
                return HttpNotFound();
            }
            return View(tbl_BookCategory);
        }

        // POST: tbl_BookCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_BookCategory tbl_BookCategory = db.tbl_BookCategory.Find(id);
            db.tbl_BookCategory.Remove(tbl_BookCategory);
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
