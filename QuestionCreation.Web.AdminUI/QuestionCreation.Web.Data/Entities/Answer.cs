namespace QuestionCreation.Web.Data.Entities
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public int? QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}
