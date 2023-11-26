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

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student student )
        {
            var values = c.Students.FirstOrDefault(x => x.smail == student.smail && x.smail == student.smail);
            if (values!=null)
            {
                FormsAuthentication.SetAuthCookie(values.smail, false);
                Session["CurrentMail"] = values.smail;
                Session.Timeout = 60;//60 dk sonra sistemden otomatik olarak  çıkış yap
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }
    }
}