using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class AboutController : Controller
    {
        ELearningContext c = new ELearningContext();
  
        public ActionResult AboutList()
        {
            var values = c.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

		[HttpPost]
		public ActionResult AddAbout(About a)
		{
            c.Abouts.Add(a);
            c.SaveChanges();
			return RedirectToAction("AboutList");
		}

        public ActionResult DeleteAbout(int id)
        {
            var sil=c.Abouts.Find(id);
            c.Abouts.Remove(sil);
            c.SaveChanges() ;
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var guncel = c.Abouts.Find(id);
            return View(guncel);
        }

		[HttpPost]
		public ActionResult UpdateAbout(About a)
		{
            var values = c.Abouts.Find(a.aboutID);
            values.aboutTittle= a.aboutTittle;
            values.aboutDescreption= a.aboutDescreption;
            values.aboutImage= a.aboutImage;
            c.SaveChanges();
            return RedirectToAction("AboutList");
			
		}
	}
}