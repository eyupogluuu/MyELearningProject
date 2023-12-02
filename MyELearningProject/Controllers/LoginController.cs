using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;

namespace MyELearningProject.Controllers
{
    public class LoginController : Controller
    {
        ELearningContext c = new ELearningContext();

        public ActionResult loginHome()
        {
            return View();
        }
        //öğrenci giriş
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student student )
        {
            var values = c.Students.FirstOrDefault(x => x.smail == student.smail && x.spassword == student.spassword);
            if (values!=null)
            {
                FormsAuthentication.SetAuthCookie(values.smail, false);
                Session["CurrentMail"] = values.smail;
                Session.Timeout = 60;//60 dk sonra sistemden otomatik olarak  çıkış yap
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }
		//admin giriş
		[HttpGet]
		public ActionResult admingiris()
		{
			return View();
		}
		[HttpPost]
		public ActionResult admingiris(Admin admin)
		{
			var values = c.admins.FirstOrDefault(x => x.adminMail == admin.adminMail && x.sifre == admin.sifre);
			if (values != null)
			{
				FormsAuthentication.SetAuthCookie(values.adminMail, false);
				Session["AdminMail"] = values.adminMail;
				Session.Timeout = 60;//60 dk sonra sistemden otomatik olarak  çıkış yap
				return RedirectToAction("Index", "Category");
			}
			return View();
		}
		//instructor giriş
		[HttpGet]
		public ActionResult instructorLogin()
		{
			return View();
		}
		[HttpPost]
		public ActionResult instructorLogin(Instructor ıns)
		{
			var values = c.Instructors.FirstOrDefault(x => x.mail == ıns.mail && x.password == ıns.password);
			if (values != null)
			{
				FormsAuthentication.SetAuthCookie(values.mail, false);
				Session["InstructorMail"] = values.mail;
				Session.Timeout = 60;//60 dk sonra sistemden otomatik olarak  çıkış yap
				return RedirectToAction("Index", "InstructorProfile");
			}
			return View();
		}

	}
}