using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
	public class DefaultController : Controller
	{
		ELearningContext c = new ELearningContext();
		veriler v = new veriler();


		public ActionResult Index()
		{
			return View();
		}


		public PartialViewResult partialHead()
		{
			return PartialView();
		}
		public PartialViewResult partialService()
		{
			var values = c.Abouts.ToList();
			return PartialView(values);
		}
		public PartialViewResult partialAbout()
		{
			var values = c.Services.ToList();
			return PartialView(values);
		}
		public PartialViewResult partialCategory()
		{
			var values = c.Categories.ToList();
			return PartialView(values);
		}
		public PartialViewResult partialCourse()
		{
			var values = c.Courses.ToList();
			return PartialView(values);
		}
		public PartialViewResult partialInstructor()
		{
			var values = c.Instructors.ToList();
			return PartialView(values);
		}
		public PartialViewResult partialTestimonial()
		{
			var values = c.Testimonials.ToList();
			return PartialView(values);
		}

		public PartialViewResult partialContact()
		{
			var values = c.Communucations.ToList();
			return PartialView(values);
		}
		[HttpGet]
		public PartialViewResult partialContact2()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult partialContact2(Contact con)
		{
			c.Contacts.Add(con);
			c.SaveChanges();
			return PartialView();
		}




	}
}