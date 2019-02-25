using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week04Homework.Models;

namespace Week04Homework.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello world!";
        }
        public ActionResult GetView ()
        {
            Employee emp = new Employee();
            emp.FirstName = "Nikolai";
            emp.LastName = "Zenevitsh";
            emp.Salary = 100000;

            ViewBag["Employee"] = emp;
            return View("MyView");
        }
    }
}