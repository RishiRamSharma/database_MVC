using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers

{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> std = new List<Student>();
            std.Add(new Student { RollNo = 101, Name = "Sahil", Class = "MCA", Subject = "Linux" });
            std.Add(new Student { RollNo = 102, Name = "Amit", Class = "MCA", Subject = "React" });
            std.Add(new Student { RollNo = 103, Name = "Mukesh", Class = "MCA", Subject = "Angular" });
            std.Add(new Student { RollNo = 104, Name = "AJ", Class = "MCA", Subject = "Big Data" });
            return View(std);
            //  Student std = new Student();
            //  std.RollNo = 101;
            //  std.Name = "Lucifer";
            //  std.Class = "MCA";
            // std.Subject = "React JS";
            // return View(std);
        }
    }
}