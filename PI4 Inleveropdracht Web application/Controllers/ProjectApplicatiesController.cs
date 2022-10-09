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
    public class ProjectApplicatiesController : Controller
    {
        private Modelss db = new Modelss();

        // GET: ProjectApplicaties
        public ActionResult Index()
        {
            return View(db.ProjectApplicaties.ToList());
        }

        // GET: ProjectApplicaties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectApplicatie projectApplicatie = db.ProjectApplicaties.Find(id);
            if (projectApplicatie == null)
            {
                return HttpNotFound();
            }
            return View(projectApplicatie);
        }

        // GET: ProjectApplicaties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectApplicaties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ApplicatieId")] ProjectApplicatie projectApplicatie)
        {
            if (ModelState.IsValid)
            {
                db.ProjectApplicaties.Add(projectApplicatie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectApplicatie);
        }

        // GET: ProjectApplicaties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectApplicatie projectApplicatie = db.ProjectApplicaties.Find(id);
            if (projectApplicatie == null)
            {
                return HttpNotFound();
            }
            return View(projectApplicatie);
        }

        // POST: ProjectApplicaties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ApplicatieId")] ProjectApplicatie projectApplicatie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectApplicatie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectApplicatie);
        }

        // GET: ProjectApplicaties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectApplicatie projectApplicatie = db.ProjectApplicaties.Find(id);
            if (projectApplicatie == null)
            {
                return HttpNotFound();
            }
            return View(projectApplicatie);
        }

        // POST: ProjectApplicaties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectApplicatie projectApplicatie = db.ProjectApplicaties.Find(id);
            db.ProjectApplicaties.Remove(projectApplicatie);
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
