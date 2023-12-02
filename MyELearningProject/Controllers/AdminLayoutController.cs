using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AdminLayoutController : Controller
    {
		ELearningContext c = new ELearningContext();
		public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
			var values = Session["AdminMail"].ToString();
			ViewBag.mail = Session["AdminMail"];
			ViewBag.name = c.admins.Where(x => x.adminMail == values.ToString())
				.Select(y => y.kullaniciAdi).FirstOrDefault();
			return PartialView();
        }
        public PartialViewResult PartialPageRowTittle()
        {
            return PartialView();
        }
        public PartialViewResult PartialPreLoader()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

    }
}