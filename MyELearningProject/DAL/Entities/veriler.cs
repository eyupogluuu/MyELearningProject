using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
	public class veriler
	{
		public IEnumerable<About> about { get; set; }
		public IEnumerable<Instructor> instructors { get; set; }
		public IEnumerable<Course> course { get; set; }
		public IEnumerable<Category> categories { get; set; }
	}
}