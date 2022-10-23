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
    public class tbl_EventController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Event
        public ActionResult Index()
        {
            return View(db.tbl_Event.ToList());
        }

        // GET: tbl_Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Event tbl_Event = db.tbl_Event.Find(id);
            if (tbl_Event == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Event);
        }

        // GET: tbl_Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Event/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_Event tbl_Event,HttpPostedFileBase event_pic)
        {
            if (event_pic != null)
            {
                string fullpath = Server.MapPath("~/ProductPIC/" + event_pic.FileName);
                event_pic.SaveAs(fullpath);
                tbl_Event.EVENT_PICTURE = "~/ProductPIC/" + event_pic.FileName;
            }

            if (ModelState.IsValid)
            {
                db.tbl_Event.Add(tbl_Event); 
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Event);
        }

        // GET: tbl_Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Event tbl_Event = db.tbl_Event.Find(id);
            if (tbl_Event == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Event);
        }

        // POST: tbl_Event/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_Event tbl_Event,HttpPostedFileBase event_pic)
        {

            if (event_pic != null)
            {
                string fullpath = Server.MapPath("~/ProductPIC/" + event_pic.FileName);
                event_pic.SaveAs(fullpath);
                tbl_Event.EVENT_PICTURE = "~/ProductPIC/" + event_pic.FileName;
            }

            if (ModelState.IsValid)
            {
                db.Entry(tbl_Event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Event);
        }

        // GET: tbl_Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Event tbl_Event = db.tbl_Event.Find(id);
            if (tbl_Event == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Event);
        }

        // POST: tbl_Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Event tbl_Event = db.tbl_Event.Find(id);
            db.tbl_Event.Remove(tbl_Event);
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
