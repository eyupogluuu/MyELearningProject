using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;


namespace MyELearningProject.Controllers
{
    public class StudentController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult StudentList()
        {
            var values = c.Students.ToList();
            if (values.Count==0)
            {
                ViewBag.hata = "Herhangi Bir Öğrenci Kaydı Bulunamamıştır";
            }
            return View(values);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student stu)
        {
            c.Students.Add(stu);
            c.SaveChanges();
            return RedirectToAction("StudentList");
        }
        public ActionResult DeleteStudent(int id)
        {
            var values = c.Students.Find(id);
            c.Students.Remove(values);
            c.SaveChanges();
            return RedirectToAction("StudentList");
        }
        public ActionResult UpdateStudent(int id)
        {
            var values = c.Students.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student stu)
        {
            var values = c.Students.Find(stu.studentID);
            values.sname = stu.sname;
            values.ssurname = stu.ssurname;
            values.smail = stu.smail;
            values.spassword = stu.spassword;
            c.SaveChanges();
            return RedirectToAction("StudentList");
        }
    }
}