using QuestionCreation.Web.Business.IService;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Business.Service
{

    public class QuizService : BaseService<Quiz, QuizViewModel>, IQuizService
    {
        private readonly IQuizRepository _repository;

        public QuizService(IQuizRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
