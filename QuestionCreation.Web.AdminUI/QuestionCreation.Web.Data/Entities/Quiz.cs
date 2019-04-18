using System.Collections.Generic;

namespace QuestionCreation.Web.Data.Entities
{
    public class Quiz : BaseModel
    {
        public string QuizName { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
