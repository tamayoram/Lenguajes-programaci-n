using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using neighborhoodStore.DAL;
using neighborhoodStore.Models;

namespace neighborhoodStore.Controllers
{
    public class CostumerController : Controller
    {
        private neighborhoodStoreContext db = new neighborhoodStoreContext();

        // GET: Costumer
        public ActionResult Index()
        {
            return View(db.Costumers.ToList());
        }

        // GET: Costumer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Costumer costumer = db.Costumers.Find(id);
            if (costumer == null)
            {
                return HttpNotFound();
            }
            return View(costumer);
        }

        // GET: Costumer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Costumer/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CostumerID,FirstName,LastName,Address,Phone")] Costumer costumer)
        {
            if (ModelState.IsValid)
            {
                db.Costumers.Add(costumer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(costumer);
        }

        // GET: Costumer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Costumer costumer = db.Costumers.Find(id);
            if (costumer == null)
            {
                return HttpNotFound();
            }
            return View(costumer);
        }

        // POST: Costumer/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CostumerID,FirstName,LastName,Address,Phone")] Costumer costumer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(costumer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(costumer);
        }

        // GET: Costumer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Costumer costumer = db.Costumers.Find(id);
            if (costumer == null)
            {
                return HttpNotFound();
            }
            return View(costumer);
        }

        // POST: Costumer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Costumer costumer = db.Costumers.Find(id);
            db.Costumers.Remove(costumer);
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
