using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
	public class Admin
	{
        public int adminID { get; set; }
        public string kullaniciAdi { get; set; }
        public string adminMail { get; set; }
        public string sifre { get; set; }
    }
}