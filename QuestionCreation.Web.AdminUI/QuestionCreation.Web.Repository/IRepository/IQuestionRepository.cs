using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;

namespace QuestionCreation.Web.Repository.IRepository
{
    public interface IQuestionRepository : IBaseRepository<Question, QuestionViewModel>
    {
    }
}
