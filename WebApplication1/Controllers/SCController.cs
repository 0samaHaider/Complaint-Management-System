using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Web;

namespace WebApplication1.Controllers
{
    public class SCController : Controller
    {
        // GET: SC
       
        

        
        public ActionResult Index()
        {
            using (DbModel1 db1 = new DbModel1())
            {
                return View(db1.Customers.ToList());

            }
        }

        // GET: SC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SC/Create
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

        // GET: SC/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModel1 db1 = new DbModel1())
            {
                return View(db1.Customers.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: SC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(customer.Customer_Email);
                // mail.To.Add("osamakiani32@gmail.com");
                mail.From = new MailAddress("artisticmania8@gmail.com", "KN Solutions");
                mail.Subject = "Confirmation Message ";
                string output = " Dear "+ customer.Customer_Name+" , \n We Resolve Your Complaint, \n Enjoy Yor Time With KN Solutions !! \n Thank You. ";
                mail.Body = output;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential("artisticmania8@gmail.com", "42Art91429142Art914291");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                ViewBag.ErrorMessage = "Email send";


            }
            catch (Exception)
            {
                ViewBag.ErrorMessage = "Email not found or matched";

            }
            try
            {
                // TODO: Add update logic here
                using (DbModel1 db1 = new DbModel1())
                {
                    db1.Entry(customer).State = EntityState.Modified;
                    db1.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SC/Delete/5
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
