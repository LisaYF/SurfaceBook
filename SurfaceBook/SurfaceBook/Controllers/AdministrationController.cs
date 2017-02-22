using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurfaceBook.Models;

namespace SurfaceBook.Controllers
{
    public class AdministrationController : Controller
    {
        private AdministrationDBContext db = new AdministrationDBContext();

        //
        // GET: /Administration/

        public ActionResult Index(string searchValue)
        {
            var items = from m in db.Administrator
                        select m;
            if (string.IsNullOrEmpty(searchValue) == false)
            {

                items = items.Where(m => m.ProductName.Contains(searchValue));
            }
            return View(items);
        }


        //
        // GET: /Administration/Details/5

        public ActionResult Details(int id = 0)
        {
            Administration administration = db.Administrator.Find(id);
            if (administration == null)
            {
                return HttpNotFound();
            }
            return View(administration);
        }

        //
        // GET: /Administration/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Administration/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Administration administration)
        {
            if (ModelState.IsValid)
            {
                db.Administrator.Add(administration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administration);
        }

        //
        // GET: /Administration/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Administration administration = db.Administrator.Find(id);
            if (administration == null)
            {
                return HttpNotFound();
            }
            return View(administration);
        }

        //
        // POST: /Administration/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Administration administration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administration);
        }

        //
        // GET: /Administration/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Administration administration = db.Administrator.Find(id);
            if (administration == null)
            {
                return HttpNotFound();
            }
            return View(administration);
        }

        //
        // POST: /Administration/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administration administration = db.Administrator.Find(id);
            db.Administrator.Remove(administration);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}