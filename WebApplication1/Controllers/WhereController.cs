using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class WhereController : Controller
    {
        // GET: Where
        public ActionResult Emp()
        {
            return View();
        }
        public ActionResult Index()
        {
            using (DbModel1 db1 = new DbModel1())
            {
                var drafts = db1.Customers.Where(d => d.Status == "Solved").ToList();
                return View(drafts);

            }
        }

        // GET: Where/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Where/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Where/Create
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

        // GET: Where/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Where/Edit/5
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

        // GET: Where/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Where/Delete/5
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
