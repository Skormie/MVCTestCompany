using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t=="m")
            {
                ViewBag.Title = "Manager Index";
                return View("ManagerIndex");
            } else
                return View();
        }
        public ContentResult Search(string name)
        {
            string input = HttpUtility.HtmlEncode(name);
            return Content(input);
        }
        public string ListAllCustomers()
        {
            return @"<ul><li>CUSTOMER1</li></ul>";
        }

        [HttpPost]
        public ActionResult NewEmployee(string firstName, string lastName, string title)
        {
            ViewBag.Message = "Name: " + firstName + " " + lastName;
            ViewBag.Message += "\tTitle: " + title;
            return View("ConfirmEmployee");
        }

        public ActionResult NewEmployee()
        {
            return View("NewEmployeeForm");
        }
    }
}