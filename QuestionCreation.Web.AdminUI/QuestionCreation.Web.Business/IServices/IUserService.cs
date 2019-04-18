using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using System.Threading.Tasks;

namespace QuestionCreation.Web.Business.IService
{
    public interface IUserService : IBaseService<User, UserViewModel>
    {
        new Task<int> Delete(int id);
        new Task<int> Update(User model);
        new Task<int> Create(User model);
    }
}
