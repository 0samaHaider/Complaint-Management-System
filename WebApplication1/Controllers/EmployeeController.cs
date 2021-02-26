using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employee()
        {
            using (DBModels db = new DBModels())
            {
            return View(db.Employees.ToList());
               
            }
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)

        {
            using (DBModels db = new DBModels())
            {
                return View(db.Employees.Where(x=> x.ID==id).FirstOrDefault());

            }
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                using(DBModels db = new DBModels())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }

                return RedirectToAction("Employee");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Employees.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
           
            try
            {
                // TODO: Add update logic here
                using (DBModels db = new DBModels())
                {
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Employee");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Employees.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModels db = new DBModels())
                {
                    employee = db.Employees.Where(x => x.ID == id).FirstOrDefault();
                    db.Employees.Remove(employee);
                    db.SaveChanges();

                }

                return RedirectToAction("Employee");
            }
            catch
            {
                return View();
            }
        }
    }
}
