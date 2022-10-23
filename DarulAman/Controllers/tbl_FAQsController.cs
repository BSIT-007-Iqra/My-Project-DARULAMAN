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
    public class tbl_FAQsController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_FAQs
        public ActionResult Index()
        {
            return View(db.tbl_FAQs.ToList());
        }

        // GET: tbl_FAQs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_FAQs tbl_FAQs = db.tbl_FAQs.Find(id);
            if (tbl_FAQs == null)
            {
                return HttpNotFound();
            }
            return View(tbl_FAQs);
        }

        // GET: tbl_FAQs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_FAQs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FAQ_ID,FAQ_QUESTION,FAQ_ANSWER")] tbl_FAQs tbl_FAQs)
        {
            if (ModelState.IsValid)
            {
                db.tbl_FAQs.Add(tbl_FAQs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_FAQs);
        }

        // GET: tbl_FAQs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_FAQs tbl_FAQs = db.tbl_FAQs.Find(id);
            if (tbl_FAQs == null)
            {
                return HttpNotFound();
            }
            return View(tbl_FAQs);
        }

        // POST: tbl_FAQs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FAQ_ID,FAQ_QUESTION,FAQ_ANSWER")] tbl_FAQs tbl_FAQs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_FAQs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_FAQs);
        }

        // GET: tbl_FAQs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_FAQs tbl_FAQs = db.tbl_FAQs.Find(id);
            if (tbl_FAQs == null)
            {
                return HttpNotFound();
            }
            return View(tbl_FAQs);
        }

        // POST: tbl_FAQs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_FAQs tbl_FAQs = db.tbl_FAQs.Find(id);
            db.tbl_FAQs.Remove(tbl_FAQs);
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
