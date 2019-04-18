using System.Linq;
using QuestionCreation.Web.Business.IService;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Business.Service
{


    public class AnswerService : BaseService<Answer, AnswerViewModel>, IAnswerService
    {
        private readonly IAnswerRepository _repository;

        public AnswerService(IAnswerRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IQueryable<AnswerViewModel> GetAnswerViewModels()
        {
            throw new System.NotImplementedException();
        }
    }
}
