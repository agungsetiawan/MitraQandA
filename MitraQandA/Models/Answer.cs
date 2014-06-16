using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MitraQandA.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public int point { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
