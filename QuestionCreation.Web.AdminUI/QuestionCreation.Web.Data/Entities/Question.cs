using System;
using System.Collections.Generic;

namespace QuestionCreation.Web.Data.Entities
{
    public class Question
    {

        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public Nullable<int> QuizID { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
