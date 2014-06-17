using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MitraQandA.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishedDate { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Answer> Answer { get; set; }

    }
}