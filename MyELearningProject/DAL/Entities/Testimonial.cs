using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Testimonial
    {
        public int testimonialID { get; set; }
        public string nameSurname { get; set; }
        public string title { get; set; }
        public string imageUrl { get; set; }
        public string comment { get; set; }
        public bool status { get; set; }
    }
}