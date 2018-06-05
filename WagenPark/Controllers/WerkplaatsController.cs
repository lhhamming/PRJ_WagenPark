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
    public class WerkplaatsController : Controller
    {
        private WagenParkContext db = new WagenParkContext();

        // GET: Werkplaats
        public ActionResult Index()
        {
            return View(db.Werkplaatsen.ToList());
        }

        // GET: Werkplaats/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Werkplaats werkplaats = db.Werkplaatsen.Find(id);
            if (werkplaats == null)
            {
                return HttpNotFound();
            }
            return View(werkplaats);
        }

        // GET: Werkplaats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Werkplaats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "werkplaatsnr,naam")] Werkplaats werkplaats)
        {
            if (ModelState.IsValid)
            {
                db.Werkplaatsen.Add(werkplaats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(werkplaats);
        }

        // GET: Werkplaats/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Werkplaats werkplaats = db.Werkplaatsen.Find(id);
            if (werkplaats == null)
            {
                return HttpNotFound();
            }
            return View(werkplaats);
        }

        // POST: Werkplaats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "werkplaatsnr,naam")] Werkplaats werkplaats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(werkplaats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(werkplaats);
        }

        // GET: Werkplaats/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Werkplaats werkplaats = db.Werkplaatsen.Find(id);
            if (werkplaats == null)
            {
                return HttpNotFound();
            }
            return View(werkplaats);
        }

        // POST: Werkplaats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Werkplaats werkplaats = db.Werkplaatsen.Find(id);
            db.Werkplaatsen.Remove(werkplaats);
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
