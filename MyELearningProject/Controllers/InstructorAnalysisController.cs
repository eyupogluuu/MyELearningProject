using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;

namespace MyELearningProject.Controllers
{
    public class InstructorAnalysisController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult InstructorPanelPartial(int id)
        {
            id = 1;
            var values = c.Instructors.Where(x => x.instructorID == id).ToList();
            var v1 = c.Instructors.Where(x => x.name == "Ahmet" && x.surname == "Ölçen").Select(y => y.instructorID).FirstOrDefault();
            ViewBag.courseCount = c.Courses.Where(x => x.instructorID == 1).Count();//kurs sayısı
			ViewBag.avgRating = c.Comments.Where(x => x.courseID == id).Average(y => y.rating);

			var v2 = c.Courses.Where(x => x.instructorID == v1).Select(y => y.courseID).ToList();
            ViewBag.commentCount = c.Comments.Where(x => v2.Contains(x.courseID)).Count();//kursa yapılan yorum sayısı
            return PartialView(values);
        }
        public PartialViewResult CommentPartial()
        {
            var v1 = c.Instructors.Where(x => x.name == "Ahmet" && x.surname == "Ölçen").Select(y => y.instructorID).FirstOrDefault();
            ViewBag.courseCount = c.Courses.Where(x => x.instructorID == 1).Count();//kurs sayısı

            var v2 = c.Courses.Where(x => x.instructorID == v1).Select(y => y.courseID).ToList();
            ViewBag.commentCount = c.Comments.Where(x => v2.Contains(x.courseID)).Count();//kursa yapılan yorum sayısı

            var v3 = c.Comments.Where(x => v2.Contains(x.courseID)).ToList();
            return PartialView(v3);
        }
        public PartialViewResult CourseListByİnstructorPartial()
        {
            int id = 1;
            ViewBag.avgRating = c.Comments.Where(x => x.courseID == id).Average(y => y.rating);
            ViewBag.commentCount=c.Comments.Where(x=>x.courseID==id).Count();
            var values = c.Courses.Where(x => x.instructorID == 1).ToList();
			return PartialView(values);
        }
    }
}