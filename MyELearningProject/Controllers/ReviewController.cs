using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class ReviewController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult reviewList()
        {
            ViewBag.ort = c.Reviews.Select(x => x.ReviewScore).Average();
            var values =c.Reviews.ToList();
            return View(values);
        }

        [HttpGet] 
        public ActionResult Addreview()
        {List<SelectListItem> cours = (from x in c.Courses.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.tittle,
                                                   Value=x.courseID.ToString()
                                               }).ToList();
            ViewBag.v = cours;
            return View();
        }

		[HttpPost]
		public ActionResult Addreview(Review r)
		{
            c.Reviews.Add(r);
            c.SaveChanges();
			return RedirectToAction("reviewList");
		}
	}
}