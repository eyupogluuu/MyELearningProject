using MyELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyELearningProject.Controllers
{
    public class ContactController : Controller
    {
		ELearningContext c = new ELearningContext();
		public ActionResult contactList()
        {
            var values = c.Contacts.ToList();
            return View(values);
        }
    }
}