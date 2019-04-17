using System;
using System.Collections.Generic;

namespace QuestionCreation.Web.Data.Entities
{
    public class Question : BaseModel
    {

        public string QuestionText { get; set; }
        public int? QuizId { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
