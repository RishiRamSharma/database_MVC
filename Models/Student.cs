using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace mvc.Models
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string  Class  { get; set; }
        public string Subject { get; set; }
    }
}