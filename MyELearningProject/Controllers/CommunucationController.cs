using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class CommunucationController : Controller
    {
        ELearningContext c = new ELearningContext();
        public ActionResult communucationList()
        {
            
            var values= c.Communucations.ToList();
            return View(values);
        }
    }
}