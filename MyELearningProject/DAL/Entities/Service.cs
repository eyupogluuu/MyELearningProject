using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Service
    {
        public int serviceID { get; set; }
        public string servicetittle { get; set; }
        public string servicedescreption { get; set; }
        public string serviceimage { get; set; }
    }
}