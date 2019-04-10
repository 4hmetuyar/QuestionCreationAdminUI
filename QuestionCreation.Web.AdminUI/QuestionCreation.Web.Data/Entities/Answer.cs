using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCreation.Web.Data.Entities
{
   public class Answer
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
        public Nullable<int> QuestionID { get; set; }

        public virtual Question Question { get; set; }
    }
}
