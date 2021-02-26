using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CustmerDetailsController : Controller
    {
        // GET: CustmerDetails
        public ActionResult Index()
        {
            using (DbModel1 db = new DbModel1())
            {
                return View(db.Customers.ToList());
            }
        }

        // GET: CustmerDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustmerDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustmerDetails/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            try
            {
                // TODO: Add insert logic here
                using (DbModel1 db = new DbModel1())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustmerDetails/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModel1 db = new DbModel1())
            {
                return View(db.Customers.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: CustmerDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModel1 db = new DbModel1())
                {
                    db.Entry(customer).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustmerDetails/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModel1 db = new DbModel1())
            {
                return View(db.Customers.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: CustmerDetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {

            try
            {
                // TODO: Add delete logic here
                using (DbModel1 db = new DbModel1())
                {
                    customer = db.Customers.Where(x => x.ID == id).FirstOrDefault();
                    db.Customers.Remove(customer);
                    db.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
