using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
	public class Playlist
	{
        public int playlistID { get; set; }
        public int courseID { get; set; }
        public Course course { get; set; }
        public string videolink { get; set; }
    }
}