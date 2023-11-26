using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class About
    {
        public int aboutID { get; set; }
		public string aboutTittle { get; set; }
		public string aboutDescreption { get; set; }
        
        public string aboutImage { get; set; }
    }
}