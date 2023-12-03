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
		[HttpGet]
		public ActionResult Index(int id=0)
		{
			var values = Session["CurrentMail"].ToString();
			ViewBag.mail = Session["CurrentMail"];
			ViewBag.name = c.Students.Where(x => x.smail == values.ToString())
				.Select(y => y.sname + " " + y.ssurname).FirstOrDefault();
			id=c.Students.Where(x=>x.smail==values).Select(y=>y.studentID).FirstOrDefault();
			var stu = c.Students.Find(id);
			return View(stu);
		}
		[HttpPost]
		public ActionResult Index(Student stu)
		{
			var values = c.Students.Find(stu.studentID);
			values.sname = stu.sname;
			values.ssurname = stu.ssurname;
			values.smail = stu.smail;
			values.spassword = stu.spassword;
			c.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult MyCourseList()
		{
			
			string values = Session["CurrentMail"].ToString();//oturum açan kişinin mailini aldım
			int id = c.Students.Where(x => x.smail == values).Select(y => y.studentID).FirstOrDefault();//maile göre öğrencinin idsini aldım
			var courselist = c.Processes.Where(x => x.studentID == id).ToList();//o idnin kayıtlı olduğu kursları getirdim
			return View(courselist);
		}
		public ActionResult playlist(int id)
		{
			ViewBag.cname = c.Courses.Where(x => x.courseID == id).Select(y => y.tittle).FirstOrDefault();
			var values = c.playlists.Where(x => x.courseID == id).ToList();
			return View(values);
		}

	}
	

}