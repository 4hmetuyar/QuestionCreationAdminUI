using System.Collections.Generic;

namespace QuestionCreation.Web.Data.Entities
{
    public class Question : BaseModel
    {
        public int? QuizId { get; set; }

        public int QuestionTypeId { get; set; }


        public string QuestionText { get; set; }
 

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual QuestionType QuestionType { get; set; }
    }
}
