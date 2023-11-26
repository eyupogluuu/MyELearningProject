using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
	public class Communucation
	{
		[Key]
        public int communcationID { get; set; }
        public string office { get; set; }
        public string phone { get; set; }
        public string mail  { get; set; }
        public string mapUrl { get; set; }
    }
}