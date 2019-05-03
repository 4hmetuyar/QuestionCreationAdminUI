using System.Web.Mvc;

namespace QuestionCreation.Web.AdminUI.Controllers
{
    public class QuizController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}