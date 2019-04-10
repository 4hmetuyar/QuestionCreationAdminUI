using System;

namespace QuestionCreation.Web.Data.Entities
{
    public partial class Choice
    {
        public int ChoiceID { get; set; }
        public string ChoiceText { get; set; }
        public Nullable<int> QuestionID { get; set; }

        public virtual Question Question { get; set; }
    }
}
