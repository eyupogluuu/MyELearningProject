using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Student
    {
        public int studentID { get; set; }
        public string sname { get; set; }
        public string ssurname { get; set; }
        public string smail { get; set; }
        public string spassword { get; set; }
        public List<CourseRegister> courseRegisters { get; set; }
        public List<Comment> comments { get; set; }
        public List<Review> reviews { get; set; }
        public List<Process> processes { get; set; }
    }
}