using System;

namespace QuestionCreation.Web.Data.Entities
{
    public class Answer :BaseModel
    {
        public int? QuestionId { get; set; }

        public string AnswerText { get; set; }
        public bool IsRightAnswer { get; set; }

        public virtual Question Question { get; set; }
    }
}
