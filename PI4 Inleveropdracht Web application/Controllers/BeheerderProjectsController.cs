using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PI4_Inleveropdracht_Web_application.Models;

namespace PI4_Inleveropdracht_Web_application.Controllers
{
    public class BeheerderProjectsController : Controller
    {
        private Modelss db = new Modelss();

        // GET: BeheerderProjects
        public ActionResult Index()
        {
            return View(db.BeheerderProjects.ToList());
        }

        // GET: BeheerderProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeheerderProject beheerderProject = db.BeheerderProjects.Find(id);
            if (beheerderProject == null)
            {
                return HttpNotFound();
            }
            return View(beheerderProject);
        }

        // GET: BeheerderProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeheerderProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BeheerderId,ProjectId")] BeheerderProject beheerderProject)
        {
            if (ModelState.IsValid)
            {
                db.BeheerderProjects.Add(beheerderProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beheerderProject);
        }

        // GET: BeheerderProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeheerderProject beheerderProject = db.BeheerderProjects.Find(id);
            if (beheerderProject == null)
            {
                return HttpNotFound();
            }
            return View(beheerderProject);
        }

        // POST: BeheerderProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BeheerderId,ProjectId")] BeheerderProject beheerderProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beheerderProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beheerderProject);
        }

        // GET: BeheerderProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeheerderProject beheerderProject = db.BeheerderProjects.Find(id);
            if (beheerderProject == null)
            {
                return HttpNotFound();
            }
            return View(beheerderProject);
        }

        // POST: BeheerderProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BeheerderProject beheerderProject = db.BeheerderProjects.Find(id);
            db.BeheerderProjects.Remove(beheerderProject);
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
