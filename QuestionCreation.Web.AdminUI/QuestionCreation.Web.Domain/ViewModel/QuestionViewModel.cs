using QuestionCreation.Web.Data.Entities;
using System.Collections.Generic;

namespace QuestionCreation.Web.Domain.ViewModel
{
    public class QuestionViewModel : BaseViewModel
    {
        public List<Question> Questions { get; set; }
    }
}
