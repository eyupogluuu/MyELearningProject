using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Instructor
    {
        
        public int instructorID { get; set; }
        public string name { get; set; }
        [StringLength(30)]
        public string surname { get; set; }
        public string imageUrl { get; set; }
        public string tittle { get; set; }
        
        public string coverimage { get; set; }
        public List<Course> Courses { get; set; }
    }
}