using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WagenPark.Classes;
using WagenPark.Models;

namespace WagenPark.Controllers
{
    public class OnderhoudsController : Controller
    {
        private WagenParkContext db = new WagenParkContext();

        // GET: Onderhouds
        public ActionResult Index()
        {
            return View(db.Onderhoud.ToList());
        }

        // GET: Onderhouds/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Onderhoud onderhoud = db.Onderhoud.Find(id);
            if (onderhoud == null)
            {
                return HttpNotFound();
            }
            return View(onderhoud);
        }

        // GET: Onderhouds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Onderhouds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Onderhoudsdatum,Kosten,AutoKenteken,werkplaats_werkplaatsnr")] Onderhoud onderhoud)
        {
            if (ModelState.IsValid)
            {
                db.Onderhoud.Add(onderhoud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(onderhoud);
        }

        // GET: Onderhouds/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Onderhoud onderhoud = db.Onderhoud.Find(id);
            if (onderhoud == null)
            {
                return HttpNotFound();
            }
            return View(onderhoud);
        }

        // POST: Onderhouds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Onderhoudsdatum,Kosten,AutoKenteken,werkplaats_werkplaatsnr")] Onderhoud onderhoud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(onderhoud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(onderhoud);
        }

        // GET: Onderhouds/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Onderhoud onderhoud = db.Onderhoud.Find(id);
            if (onderhoud == null)
            {
                return HttpNotFound();
            }
            return View(onderhoud);
        }

        // POST: Onderhouds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Onderhoud onderhoud = db.Onderhoud.Find(id);
            db.Onderhoud.Remove(onderhoud);
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
