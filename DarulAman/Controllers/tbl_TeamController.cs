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
    public class tbl_TeamController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Team
        public ActionResult Index()
        {
            return View(db.tbl_Team.ToList());
        }

        // GET: tbl_Team/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Team tbl_Team = db.tbl_Team.Find(id);
            if (tbl_Team == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Team);
        }

        // GET: tbl_Team/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Team/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_Team tbl_Team,HttpPostedFileBase team_pic)
        {
            string fullpath = Server.MapPath("~/ProductPIC/" + team_pic.FileName);
            team_pic.SaveAs(fullpath);
            tbl_Team.PICTURE = "~/ProductPIC/" + team_pic.FileName;
            if (ModelState.IsValid)
            {
                db.tbl_Team.Add(tbl_Team);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Team);
        }

        // GET: tbl_Team/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Team tbl_Team = db.tbl_Team.Find(id);
            if (tbl_Team == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Team);
        }

        // POST: tbl_Team/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_Team tbl_Team,HttpPostedFileBase team_pic)
        {
            if (team_pic != null)
            {
                string fullpath = Server.MapPath("~/Content/Pictures/" + team_pic.FileName);
                team_pic.SaveAs(fullpath);
                tbl_Team.PICTURE = "~/Content/Pictures/" + team_pic.FileName;
            }
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Team).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Team);
        }

        // GET: tbl_Team/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Team tbl_Team = db.tbl_Team.Find(id);
            if (tbl_Team == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Team);
        }

        // POST: tbl_Team/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Team tbl_Team = db.tbl_Team.Find(id);
            db.tbl_Team.Remove(tbl_Team);
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
