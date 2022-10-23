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
    public class tbl_SliderController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Slider
        public ActionResult Index()
        {
            return View(db.tbl_Slider.ToList());
        }

        // GET: tbl_Slider/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Slider tbl_Slider = db.tbl_Slider.Find(id);
            if (tbl_Slider == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Slider);
        }

        // GET: tbl_Slider/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Slider/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_Slider tbl_Slider,HttpPostedFileBase slider_pic)
        {
            string fullpath = Server.MapPath("~/ProductPIC/" + slider_pic.FileName);
            slider_pic.SaveAs(fullpath);
            tbl_Slider.SLIDER_PICTURE = "~/ProductPIC/" + slider_pic.FileName;
            if (ModelState.IsValid)
            {
                db.tbl_Slider.Add(tbl_Slider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Slider);
        }

        // GET: tbl_Slider/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Slider tbl_Slider = db.tbl_Slider.Find(id);
            if (tbl_Slider == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Slider);
        }

        // POST: tbl_Slider/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_Slider tbl_Slider,HttpPostedFileBase slider_pic)
        {
            if (slider_pic != null)
            {
                string fullpath = Server.MapPath("~/Content/Pictures/" + slider_pic.FileName);
                slider_pic.SaveAs(fullpath);
                tbl_Slider.SLIDER_PICTURE = "~/Content/Pictures/" + slider_pic.FileName;
            }
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Slider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Slider);
        }

        // GET: tbl_Slider/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Slider tbl_Slider = db.tbl_Slider.Find(id);
            if (tbl_Slider == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Slider);
        }

        // POST: tbl_Slider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Slider tbl_Slider = db.tbl_Slider.Find(id);
            db.tbl_Slider.Remove(tbl_Slider);
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
