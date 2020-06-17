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
    public class SaleController : Controller
    {
        private neighborhoodStoreContext db = new neighborhoodStoreContext();

        // GET: Sale
        public ActionResult Index()
        {
            var sales = db.Sales.Include(s => s.Costumers).Include(s => s.Products);
            return View(sales.ToList());
        }

        // GET: Sale/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // GET: Sale/Create
        public ActionResult Create()
        {
            ViewBag.CostumerID = new SelectList(db.Costumers, "CostumerID", "FirstName");
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Description");
            return View();
        }

        // POST: Sale/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SaleID,CostumerID,ProductID,TypeSale,Amount")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Sales.Add(sale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CostumerID = new SelectList(db.Costumers, "CostumerID", "FirstName", sale.CostumerID);
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Description", sale.ProductID);
            return View(sale);
        }

        // GET: Sale/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            ViewBag.CostumerID = new SelectList(db.Costumers, "CostumerID", "FirstName", sale.CostumerID);
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Description", sale.ProductID);
            return View(sale);
        }

        // POST: Sale/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SaleID,CostumerID,ProductID,TypeSale,Amount")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CostumerID = new SelectList(db.Costumers, "CostumerID", "FirstName", sale.CostumerID);
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Description", sale.ProductID);
            return View(sale);
        }

        // GET: Sale/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // POST: Sale/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sale sale = db.Sales.Find(id);
            db.Sales.Remove(sale);
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
