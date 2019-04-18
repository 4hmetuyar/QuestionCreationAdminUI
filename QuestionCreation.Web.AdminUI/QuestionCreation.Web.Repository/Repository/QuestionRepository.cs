using QuestionCreation.Web.Data;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Repository.Repository
{
    public class QuestionRepository : BaseRepository<Question, QuestionViewModel>, IQuestionRepository
    {
        private readonly DataContext _context;

        public QuestionRepository(DataContext context) : base(context)
        {
            _context = context;
        }

    }
}
