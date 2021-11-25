using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            string user = f["txtUser"];
            string pass = f["txtPass"];
            if (user.Equals("navya") && pass.Equals("12345"))
                return RedirectToAction("NewEmp", "Employee");
            else
                ViewBag.info = "Please check username / password";
            return View();
        }
    }
}