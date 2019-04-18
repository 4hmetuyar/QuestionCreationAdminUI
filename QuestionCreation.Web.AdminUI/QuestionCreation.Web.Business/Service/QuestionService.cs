using QuestionCreation.Web.Business.IService;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Business.Service
{

    public class QuestionService : BaseService<Question, QuestionViewModel>, IQuestionService
    {
        private readonly IQuestionRepository _repository;

        public QuestionService(IQuestionRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
