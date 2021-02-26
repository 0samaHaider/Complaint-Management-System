using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AllComplaintsController : Controller
    {
        // GET: AllComplaints
        public ActionResult Index()
        {
            using (DbModel1 db1 = new DbModel1())
            {
                return View(db1.Customers.ToList());

            }
        }

        // GET: AllComplaints/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AllComplaints/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AllComplaints/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AllComplaints/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AllComplaints/Edit/5
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

        // GET: AllComplaints/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AllComplaints/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
