using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;

namespace MyELearningProject.Controllers
{
    public class CategoryController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult Index()
        {
            var values = c.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            c.Categories.Add(category);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = c.Categories.Find(id);// önce silinecek kategoriyi bul
            c.Categories.Remove(values);//bulduğun categoryi sil
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = c.Categories.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category cate)
        {
            var values = c.Categories.Find(cate.categoryID);
            values.categoryName = cate.categoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}