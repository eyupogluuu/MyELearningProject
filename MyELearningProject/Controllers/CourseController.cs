using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;

namespace MyELearningProject.Controllers
{
    public class CourseController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult CourseList()
        {
            ViewBag.tittle = "Kurs Listesi";
            
            var values = c.Courses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCourse()
        {
            List<SelectListItem> categories = (from x in c.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.categoryName,
                                                   Value=x.categoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;

            List<SelectListItem> instructors = (from x in c.Instructors.ToList().OrderBy(z=>z.name)
                                                select new SelectListItem
                                                {
                                                    Text = x.name + " " + x.surname,
                                                    Value = x.instructorID.ToString()
                                                }).ToList();
            ViewBag.v2 = instructors;
            return View();
                
        }

        [HttpPost]
        public ActionResult AddCourse(Course cour)
        {
            c.Courses.Add(cour);
            c.SaveChanges();
            return RedirectToAction("CourseList");
        }

        public ActionResult DeleteCourse(int id)
        {
            var crs = c.Courses.Find(id);
            c.Courses.Remove(crs);
            c.SaveChanges();
            return RedirectToAction("CourseList");
        }
        public ActionResult UpdateCourse(int id)
        {
            List<SelectListItem> categories = (from x in c.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.categoryName,
                                                   Value = x.categoryID.ToString()
                                               }).ToList();
            ViewBag.v = categories;

            List<SelectListItem> instructors = (from x in c.Instructors.ToList().OrderBy(z => z.name)
                                                select new SelectListItem
                                                {
                                                    Text = x.name + " " + x.surname,
                                                    Value = x.instructorID.ToString()
                                                }).ToList();
            ViewBag.v2 = instructors;
            var value = c.Courses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCourse(Course crs)
        {
            var values = c.Courses.Find(crs.courseID);
            values.tittle = crs.tittle;
            values.price = crs.price;
            values.duration = crs.duration;
            values.imageUrl = crs.imageUrl;
            values.categoryID = crs.categoryID;
            values.instructorID = crs.instructorID;
            c.SaveChanges();
            return RedirectToAction("CourseList");
        }
    }
}