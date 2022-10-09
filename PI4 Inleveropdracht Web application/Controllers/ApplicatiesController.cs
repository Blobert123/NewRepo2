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
    public class ApplicatiesController : Controller
    {
        private Modelss db = new Modelss();

        // GET: Applicaties
        public ActionResult Index()
        {
            if (Session["StudentNaam"] != null)
            {
                int ofe = Convert.ToInt32(Session["StudentId"]);

                var help = from a in db.Applicaties
                           where a.ApplicatieId == ofe
                           select a;
                return View(help.DefaultIfEmpty());
            }
            else
            {
                return View(db.Applicaties.ToList());
            }    
        }

        // GET: Applicaties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicatie applicatie = db.Applicaties.Find(id);
            if (applicatie == null)
            {
                return HttpNotFound();
            }
            return View(applicatie);
        }

        // GET: Applicaties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applicaties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicatieId,naam,beschrijving")] Applicatie applicatie)
        {
            if (ModelState.IsValid)
            {
                db.Applicaties.Add(applicatie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicatie);
        }

        // GET: Applicaties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicatie applicatie = db.Applicaties.Find(id);
            if (applicatie == null)
            {
                return HttpNotFound();
            }
            return View(applicatie);
        }

        // POST: Applicaties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicatieId,naam,beschrijving")] Applicatie applicatie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicatie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicatie);
        }

        // GET: Applicaties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicatie applicatie = db.Applicaties.Find(id);
            if (applicatie == null)
            {
                return HttpNotFound();
            }
            return View(applicatie);
        }

        // POST: Applicaties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicatie applicatie = db.Applicaties.Find(id);
            db.Applicaties.Remove(applicatie);
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