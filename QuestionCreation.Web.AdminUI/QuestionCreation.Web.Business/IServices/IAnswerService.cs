using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionCreation.Web.Business.IService
{
    public interface IAnswerService : IBaseService<Answer, AnswerViewModel>
    {
        IQueryable<AnswerViewModel> GetAnswerViewModels();
        new Task<int> Delete(int id);
        new Task<int> Update(Answer model);
        new Task<int> Create(Answer model);
    }
}
