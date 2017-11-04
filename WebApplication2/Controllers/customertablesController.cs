using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class customertablesController : Controller
    {
        private customertab db = new customertab();

        // GET: customertables
        public ActionResult Index()
        {
            return View(db.customertables.ToList());
        }

        // GET: customertables/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customertable customertable = db.customertables.Find(id);
            if (customertable == null)
            {
                return HttpNotFound();
            }
            return View(customertable);
        }

        // GET: customertables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: customertables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,CustomerName,Phone,City,Email")] customertable customertable)
        {
            if (ModelState.IsValid)
            {
                db.customertables.Add(customertable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customertable);
        }

        // GET: customertables/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customertable customertable = db.customertables.Find(id);
            if (customertable == null)
            {
                return HttpNotFound();
            }
            return View(customertable);
        }

        // POST: customertables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,CustomerName,Phone,City,Email")] customertable customertable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customertable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customertable);
        }

        // GET: customertables/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customertable customertable = db.customertables.Find(id);
            if (customertable == null)
            {
                return HttpNotFound();
            }
            return View(customertable);
        }

        // POST: customertables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            customertable customertable = db.customertables.Find(id);
            db.customertables.Remove(customertable);
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
