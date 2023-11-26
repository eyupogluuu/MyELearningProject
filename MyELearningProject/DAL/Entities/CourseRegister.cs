using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class CourseRegister
    {
        public int CourseRegisterID { get; set; }
        public int studentID { get; set; }
        public Student student { get; set; }
        public int courseID { get; set; }
        public Course course { get; set; }
        [Column("Date")]
        public DateTime registerDate { get; set; }
    }
}