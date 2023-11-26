using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;

namespace MyELearningProject.Controllers
{
    public class TestimonialController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult TestimonialList()
        {
            var values = c.Testimonials.Where(x=>x.status==true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial t)
        {
            c.Testimonials.Add(t);
            c.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = c.Testimonials.Find(id);
            values.status = false;//c.Testimonials.Remove(values);
            c.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = c.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial t)
        {
            var values = c.Testimonials.Find(t.testimonialID);
            values.nameSurname = t.nameSurname;
            values.title = t.title;
            values.imageUrl = t.imageUrl;
            values.comment = t.comment;
            values.status = t.status;
            c.SaveChanges();
            return RedirectToAction("TestimonialList");
            
        }
    }
}