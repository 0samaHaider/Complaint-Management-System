using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {


        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(Account Acc)
        {
            if (Acc.Name == "admin" && Acc.Password == "qwerty")
            {
                return View("Admin");
            }
            else if (Acc.Name=="scott" && Acc.Password =="tiger")
            {
                return View("Verify");

            }
            else
            {
                return View("Error");
            }

        }
        public ActionResult admin()
        {
            return View();
        }
    }
        
}