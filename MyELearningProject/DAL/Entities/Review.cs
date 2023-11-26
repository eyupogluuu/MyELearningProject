using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int CourseID { get; set; }
        public virtual Course course { get; set; }
        public int StudentID { get; set; }
        public virtual Student student { get; set; }
        public int ReviewScore { get; set; }
    }
}