using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        // loading of page
        [HttpGet]
        public ActionResult NewEmp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewEmp(string txtName, string ddlJob)
        {
            if (ddlJob == "-1")
                ViewBag.empinfo = "Please select Job";
            else
                ViewBag.empinfo = txtName + " Working As " + ddlJob;
            return View();
        }

        public ActionResult ShowEmp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowEmp(FormCollection f)
        {
            string ename = f["txtName"].ToString();
            string job = f["ddlJob"].ToString();

            if (job == "-1")
                ViewBag.empinfo = "Please select Job";
            else
                ViewBag.empinfo = ename + " Working As " + job;
            return View();
        }
    }
}