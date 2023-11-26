using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Process
    {
        public int processID { get; set; }
        public int studentID { get; set; }
        public virtual Student student { get; set; }
        public int courseID { get; set; }
        public virtual Course course { get; set; }
    }
}