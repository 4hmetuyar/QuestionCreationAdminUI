using QuestionCreation.Web.Data.Entities;
using System.Collections.Generic;

namespace QuestionCreation.Web.Domain.ViewModel
{


    public class QuizViewModel : BaseViewModel
    {
        public List<Quiz> Quizzes { get; set; }
    }
}
