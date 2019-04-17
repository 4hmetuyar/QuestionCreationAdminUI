using System;

namespace QuestionCreation.Web.Data.Entities
{
    public partial class Choice : BaseModel
    {
        public string ChoiceText { get; set; }
        public int? QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}
