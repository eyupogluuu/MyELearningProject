using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;

namespace MyELearningProject.Controllers
{
    public class InstructorController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult InstructorList()
        {
            var values = c.Instructors.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInstructor(Instructor ınst)
        {
            c.Instructors.Add(ınst);
            c.SaveChanges();
            return RedirectToAction("InstructorList");
        }
        public ActionResult DeleteInstructor(int id)
        {
            var values = c.Instructors.Find(id);
            c.Instructors.Remove(values);
            c.SaveChanges();
            return RedirectToAction("InstructorList");
        }
        [HttpGet]
        public ActionResult UpdateInstructor(int id)
        {
            var values = c.Instructors.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateInstructor(Instructor inst)
        {
            var values = c.Instructors.Find(inst.instructorID);
            values.name = inst.name;
            values.surname = inst.surname;
            values.imageUrl = inst.imageUrl;
            c.SaveChanges();
            return RedirectToAction("InstructorList");
        }
    }
}