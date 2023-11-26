using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Comment
    {
        public int commentId { get; set; }
        public string commentText { get; set; }
        public int rating { get; set; }
        public DateTime commentDate { get; set; }
        public bool commentStatus { get; set; }
        public int studentID { get; set; } // her yorumu yapan bir öğrenci olmak zorunda
        public virtual Student student { get; set; }
        public int courseID { get; set; }
        public virtual Course course { get; set; }
    }
}