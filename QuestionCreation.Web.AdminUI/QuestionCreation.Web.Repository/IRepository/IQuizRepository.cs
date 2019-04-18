using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;

namespace QuestionCreation.Web.Repository.IRepository
{
    public interface IQuizRepository : IBaseRepository<Quiz, QuizViewModel>
    {
    }
}
