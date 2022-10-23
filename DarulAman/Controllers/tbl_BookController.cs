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
    public class tbl_BookController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Book
        public ActionResult Index()
        {
            var tbl_Book = db.tbl_Book.Include(t => t.tbl_BookCategory);
            return View(tbl_Book.ToList());
        }

        // GET: tbl_Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Book tbl_Book = db.tbl_Book.Find(id);
            if (tbl_Book == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Book);
        }

        // GET: tbl_Book/Create
        public ActionResult Create()
        {
            ViewBag.CATEGORY_FID = new SelectList(db.tbl_BookCategory, "CATEGORY_ID", "CATEGORY_NAME");
            return View();
        }

        // POST: tbl_Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BOOK_ID,BOOK_NAME,BOOK_AUTHOR,BOOK_PICTURE,BOOK_DETAIL,BOOK_PDF,CATEGORY_FID")] tbl_Book tbl_Book)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Book.Add(tbl_Book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CATEGORY_FID = new SelectList(db.tbl_BookCategory, "CATEGORY_ID", "CATEGORY_NAME", tbl_Book.CATEGORY_FID);
            return View(tbl_Book);
        }

        // GET: tbl_Book/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Book tbl_Book = db.tbl_Book.Find(id);
            if (tbl_Book == null)
            {
                return HttpNotFound();
            }
            ViewBag.CATEGORY_FID = new SelectList(db.tbl_BookCategory, "CATEGORY_ID", "CATEGORY_NAME", tbl_Book.CATEGORY_FID);
            return View(tbl_Book);
        }

        // POST: tbl_Book/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BOOK_ID,BOOK_NAME,BOOK_AUTHOR,BOOK_PICTURE,BOOK_DETAIL,BOOK_PDF,CATEGORY_FID")] tbl_Book tbl_Book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CATEGORY_FID = new SelectList(db.tbl_BookCategory, "CATEGORY_ID", "CATEGORY_NAME", tbl_Book.CATEGORY_FID);
            return View(tbl_Book);
        }

        // GET: tbl_Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Book tbl_Book = db.tbl_Book.Find(id);
            if (tbl_Book == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Book);
        }

        // POST: tbl_Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Book tbl_Book = db.tbl_Book.Find(id);
            db.tbl_Book.Remove(tbl_Book);
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
