using mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {

         List<Teacher> teachh = new List<Teacher>();
            teachh.Add(new Teacher { TeacherId = 201, Name = "Bajrang", Class = "MCA", Salary = 35000 });
            teachh.Add(new Teacher { TeacherId = 202, Name = "Gourav", Class = "MCA", Salary = 34000 });
            teachh.Add(new Teacher { TeacherId = 203, Name = "Vishal", Class = "MCA", Salary = 75000 });
            teachh.Add(new Teacher { TeacherId = 204, Name = "Gurpreet", Class = "MCA", Salary = 55000 });
            return View(teachh);

            //Teacher teach =   new Teacher();
            //teach.TeacherId = 1001;
            //teach.Name = "Neeraj Sahu";
            //teach.Class = "MCA";
            //teach.Salary = 40000;
            //return View(teach);
        }
    }
}