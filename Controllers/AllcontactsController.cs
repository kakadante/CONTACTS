using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CONTACTS.Models;

namespace CONTACTS.Controllers
{
    public class AllcontactsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Allcontacts
        public ActionResult Index()
        {
            var allcontacts = db.Allcontacts.Include(a => a.Gender);
            return View(allcontacts.ToList());
        }

        // GET: Allcontacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allcontacts allcontacts = db.Allcontacts.Find(id);
            if (allcontacts == null)
            {
                return HttpNotFound();
            }
            return View(allcontacts);
        }

        // GET: Allcontacts/Create
        public ActionResult Create()
        {
            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Gendername");
            return View();
        }

        // POST: Allcontacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone_Number,Email,GenderId")] Allcontacts allcontacts)
        {
            if (ModelState.IsValid)
            {
                db.Allcontacts.Add(allcontacts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Gendername", allcontacts.GenderId);
            return View(allcontacts);
        }

        // GET: Allcontacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allcontacts allcontacts = db.Allcontacts.Find(id);
            if (allcontacts == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Gendername", allcontacts.GenderId);
            return View(allcontacts);
        }

        // POST: Allcontacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone_Number,Email,GenderId")] Allcontacts allcontacts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allcontacts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenderId = new SelectList(db.Genders, "Id", "Gendername", allcontacts.GenderId);
            return View(allcontacts);
        }

        // GET: Allcontacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allcontacts allcontacts = db.Allcontacts.Find(id);
            if (allcontacts == null)
            {
                return HttpNotFound();
            }
            return View(allcontacts);
        }

        // POST: Allcontacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Allcontacts allcontacts = db.Allcontacts.Find(id);
            db.Allcontacts.Remove(allcontacts);
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
