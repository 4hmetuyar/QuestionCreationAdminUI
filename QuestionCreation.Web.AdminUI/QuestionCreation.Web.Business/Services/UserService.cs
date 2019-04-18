using QuestionCreation.Web.Business.IService;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Business.Service
{
    public class UserService : BaseService<User, UserViewModel>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
