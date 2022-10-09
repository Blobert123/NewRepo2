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
    public class BeheerderApplicatiesController : Controller
    {
        private Modelss db = new Modelss();

        // GET: BeheerderApplicaties
        public ActionResult Index()
        {
            return View(db.BeheerderApplicaties.ToList());
        }

        // GET: BeheerderApplicaties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeheerderApplicatie beheerderApplicatie = db.BeheerderApplicaties.Find(id);
            if (beheerderApplicatie == null)
            {
                return HttpNotFound();
            }
            return View(beheerderApplicatie);
        }

        // GET: BeheerderApplicaties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeheerderApplicaties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BeheerderId,ProjectId")] BeheerderApplicatie beheerderApplicatie)
        {
            if (ModelState.IsValid)
            {
                db.BeheerderApplicaties.Add(beheerderApplicatie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beheerderApplicatie);
        }

        // GET: BeheerderApplicaties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeheerderApplicatie beheerderApplicatie = db.BeheerderApplicaties.Find(id);
            if (beheerderApplicatie == null)
            {
                return HttpNotFound();
            }
            return View(beheerderApplicatie);
        }

        // POST: BeheerderApplicaties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BeheerderId,ProjectId")] BeheerderApplicatie beheerderApplicatie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beheerderApplicatie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beheerderApplicatie);
        }

        // GET: BeheerderApplicaties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeheerderApplicatie beheerderApplicatie = db.BeheerderApplicaties.Find(id);
            if (beheerderApplicatie == null)
            {
                return HttpNotFound();
            }
            return View(beheerderApplicatie);
        }

        // POST: BeheerderApplicaties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BeheerderApplicatie beheerderApplicatie = db.BeheerderApplicaties.Find(id);
            db.BeheerderApplicaties.Remove(beheerderApplicatie);
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
