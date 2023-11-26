using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities; 

namespace MyELearningProject.Controllers
{
    public class ProfileController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult Index()
        {
            var values = Session["CurrentMail"].ToString();
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.name = c.Students.Where(x => x.smail == values.ToString())
                .Select(y => y.sname + " " + y.ssurname).FirstOrDefault();
            return View();
        }

        public ActionResult MyCourseList()
        {
            string values = Session["CurrentMail"].ToString();//oturum açan kişinin mailini aldım
            int id = c.Students.Where(x => x.smail == values).Select(y => y.studentID).FirstOrDefault();//maile göre öğrencinin idsini aldım
            var courselist = c.Processes.Where(x => x.studentID == id).ToList();//o idnin kayıtlı olduğu kursları getirdim
            return View(courselist);
        }

        }
}