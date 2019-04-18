using System.Threading.Tasks;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;

namespace QuestionCreation.Web.Business.IService
{
    public interface IQuestionService : IBaseService<Question, QuestionViewModel>
    {
        new Task<int> Delete(int id);
        new Task<int> Update(Question model);
        new Task<int> Create(Question model);
    }
}
