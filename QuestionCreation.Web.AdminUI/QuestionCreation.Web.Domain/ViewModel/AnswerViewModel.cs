using QuestionCreation.Web.Data.Entities;
using System.Collections.Generic;

namespace QuestionCreation.Web.Domain.ViewModel
{

    public class AnswerViewModel : BaseViewModel
    {
        public List<Answer> Answers { get; set; }
    }
}
