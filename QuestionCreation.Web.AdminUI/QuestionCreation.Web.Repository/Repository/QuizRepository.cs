using QuestionCreation.Web.Data;
using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Repository.IRepository;

namespace QuestionCreation.Web.Repository.Repository
{


    public class QuizRepository : BaseRepository<Quiz, QuizViewModel>, IQuizRepository
    {
        private readonly DataContext _context;

        public QuizRepository(DataContext context) : base(context)
        {
            _context = context;
        }

    }
}
