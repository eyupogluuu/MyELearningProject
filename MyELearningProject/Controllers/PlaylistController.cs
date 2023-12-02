using MyELearningProject.DAL.Context;
using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class PlaylistController : Controller
    {
		ELearningContext c = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }

		
	}
}