using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
	public class Contact
	{
        public int contactID { get; set; }
        public string nameSurname { get; set; }
        public string mail { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}