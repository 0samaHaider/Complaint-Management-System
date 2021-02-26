using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {

        // GET: Customer
        public ActionResult Customers()
        {
            using (DbModel1 db1 = new DbModel1())
            {
            return View(db1.Customers.ToList());

            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModel1 db1 = new DbModel1())
                {
                    db1.Customers.Add(customer);
                    db1.SaveChanges();
                }

                return RedirectToAction("Customers");
            }
            catch
            {
                return View();
            }



        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModel1 db1 = new DbModel1())
            {
                return View(db1.Customers.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {

            try
            {
                // TODO: Add delete logic here
                using (DbModel1 db1 = new DbModel1())
                {
                    customer = db1.Customers.Where(x => x.ID == id).FirstOrDefault();
                    db1.Customers.Remove(customer);
                    db1.SaveChanges();

                }

                return RedirectToAction("Customers");
            }
            catch
            {
                return View();
            }
        }
    }
}
