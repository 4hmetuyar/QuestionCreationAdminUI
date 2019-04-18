using System.Threading.Tasks;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;

namespace QuestionCreation.Web.Business.IService
{
    public interface IQuizService : IBaseService<Quiz, QuizViewModel>
    {
        new Task<int> Delete(int id);
        new Task<int> Update(Quiz model);
        new Task<int> Create(Quiz model);
    }
}
