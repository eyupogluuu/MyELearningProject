using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
	public class InstructorProfileController : Controller
	{
		ELearningContext c = new ELearningContext();
		public ActionResult Index()
		{
			var values = Session["InstructorMail"].ToString();
			ViewBag.mail = Session["InstructorMail"];
			ViewBag.instname = c.Instructors.Where(x => x.mail == values.ToString())
				.Select(y => y.name + " " + y.surname).FirstOrDefault();
			return View();
		}
		public ActionResult myCourseList()
		{
			
			string values = Session["InstructorMail"].ToString();//eğitmenin mailini aldım
			int id = c.Instructors.Where(x => x.mail == values).Select(y => y.instructorID).FirstOrDefault();//valuesdeki maile göre eğitmenin idsini aldım
			var courselist = c.Courses.Where(x => x.instructorID == id).ToList();
			ViewBag.inscoursecount = c.Courses.Where(x => x.instructorID == id).Count();
			return View(courselist);
		}
		//öğrenciler gelecek
		public ActionResult myStudent()
		{
			string value = Session["InstructorMail"].ToString();
			int instructorID = c.Instructors.Where(x => x.mail == value).Select(y => y.instructorID).FirstOrDefault();
			var includetables = c.CourseRegisters.Include("Course").Include("Student");
			var instructorStudents = includetables.Where(x => x.course.instructorID == instructorID).ToList();
			return View(instructorStudents);
			
		}

		[HttpGet]
		public ActionResult AddVideo(int id)
		{
			ViewBag.id = id;
			ViewBag.courseName = c.Courses.Where(x => x.courseID == id).Select(x => x.tittle).FirstOrDefault();
			var values = c.playlists.Where(x => x.courseID == id).ToList();
			return View(values);
		}
		[HttpPost]
		public ActionResult AddVideo(Playlist ply)
		{
			c.playlists.Add(ply);
			c.SaveChanges();
			return RedirectToAction("myCourseList");
		}
		public ActionResult DeleteVideo(int id)
		{
			var value = c.playlists.Find(id);
			c.playlists.Remove(value);
			c.SaveChanges();
			return RedirectToAction("myCourseList");
		}
		[HttpGet]
		public ActionResult UpdateCourse(int id)
		{
			
			List<SelectListItem> categories = (from x in c.Categories.ToList()
											   select new SelectListItem
											   {
												   Text = x.categoryName,
												   Value = x.categoryID.ToString()
											   }).ToList();
			ViewBag.categories = categories;
			List<SelectListItem> instructors = (from x in c.Instructors.ToList()
												select new SelectListItem
												{
													Text = x.name + " " + x.surname,
													Value = x.instructorID.ToString()
												}).ToList();
			ViewBag.instructors = instructors;

			var value = c.Courses.Where(x => x.courseID == id).FirstOrDefault();
			return View(value);
		}
		[HttpPost]
		public ActionResult UpdateCourse(Course course)
		{
			
			var value = c.Courses.Find(course.courseID);
			value.tittle = course.tittle;
			value.price = course.price;
			value.duration = course.duration;
			value.imageUrl = course.imageUrl;
			c.SaveChanges();
			return RedirectToAction("myCourseList");
		}

	}
}