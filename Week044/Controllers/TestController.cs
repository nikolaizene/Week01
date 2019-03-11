using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Facade;
using Microsoft.AspNetCore.Mvc;

namespace Week044.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            var emp = new Employee("Sukesh", "Marla", 20000);

            var vmEmp = new EmployeeViewModel(emp, "Admin");
            return View("MyView", vmEmp);
        }
    }
}