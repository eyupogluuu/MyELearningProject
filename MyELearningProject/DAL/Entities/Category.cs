using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string categoryimage { get; set; }
        public List<Course> Courses { get; set; }
    }
}