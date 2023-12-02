using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Course
    {
        public int courseID { get; set; }
        public string tittle { get; set; }
        public int price { get; set; }
        public int duration { get; set; }
        public string imageUrl { get; set; }
        public string descreption { get; set; }
        public int categoryID { get; set; }
        public virtual Category category { get; set; }
        public int instructorID { get; set; }
        public virtual Instructor ınstructor { get; set; }
        public List<CourseRegister> courseRegisters { get; set; }
        public List<Comment> comments { get; set; }
        public List<Review> reviews { get; set; }
        public List<Process> processes { get; set; }
        

       

    }
}