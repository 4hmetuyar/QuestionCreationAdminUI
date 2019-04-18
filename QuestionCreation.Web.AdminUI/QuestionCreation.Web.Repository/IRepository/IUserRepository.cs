using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;

namespace QuestionCreation.Web.Repository.IRepository
{
    public interface IUserRepository : IBaseRepository<User, UserViewModel>
    {
    }
}
