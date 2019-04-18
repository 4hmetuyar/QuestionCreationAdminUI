using QuestionCreation.Web.Data;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Repository.Repository
{
    public class AnswerRepository : BaseRepository<Answer,AnswerViewModel>, IAnswerRepository
    {
        private readonly DataContext _context;

        public AnswerRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    
    }


}
