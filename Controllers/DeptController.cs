using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            List<Department> deptt = new List<Department>();
            deptt.Add(new Department { DeptId = 301, DeptName = "Computer Science amd Application", DeptHOD = " Dr. Anupam Bhatia"});
            deptt.Add(new Department { DeptId = 302, DeptName = "Yoga and Science", DeptHOD = "Dr. Virender Kumar "});
            deptt.Add(new Department { DeptId = 303, DeptName = "Economic Science", DeptHOD = "Dr. Manju Rani"});
            return View(deptt);
        }
    }
}