using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PI4_Inleveropdracht_Web_application.Models;

namespace PI4_Inleveropdracht_Web_application.Controllers
{
    public class BeheerdersController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BeheerderLogin(Beheerder objUser)
        {
            if (ModelState.IsValid)
            {
                using (Modelss db = new Modelss())
                {
                    var obj = db.Beheerders.Where(a => a.BeheerderNaam.Equals(objUser.BeheerderNaam) && a.BeheerderWachtwoord.Equals(objUser.BeheerderWachtwoord)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["BeheerderId"] = obj.BeheerderId.ToString();
                        Session["BeheerderNaam"] = obj.BeheerderNaam.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult BeheerderLogout()
        {
            Session["BeheerderNaam"] = null;
            return RedirectToAction("Login", "Students");
        }

        private Modelss db = new Modelss();

        // GET: Beheerders
        public ActionResult Index()
        {
            return View(db.Beheerders.ToList());
        }

        // GET: Beheerders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beheerder beheerder = db.Beheerders.Find(id);
            if (beheerder == null)
            {
                return HttpNotFound();
            }
            return View(beheerder);
        }

        // GET: Beheerders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Beheerders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BeheerderId,naam,wachtwoord")] Beheerder beheerder)
        {
            if (ModelState.IsValid)
            {
                db.Beheerders.Add(beheerder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beheerder);
        }

        // GET: Beheerders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beheerder beheerder = db.Beheerders.Find(id);
            if (beheerder == null)
            {
                return HttpNotFound();
            }
            return View(beheerder);
        }

        // POST: Beheerders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BeheerderId,naam,wachtwoord")] Beheerder beheerder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beheerder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beheerder);
        }

        // GET: Beheerders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beheerder beheerder = db.Beheerders.Find(id);
            if (beheerder == null)
            {
                return HttpNotFound();
            }
            return View(beheerder);
        }

        // POST: Beheerders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Beheerder beheerder = db.Beheerders.Find(id);
            db.Beheerders.Remove(beheerder);
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
