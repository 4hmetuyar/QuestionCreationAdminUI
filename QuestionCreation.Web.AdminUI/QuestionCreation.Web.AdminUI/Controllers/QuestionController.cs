using System.Web.Mvc;

namespace QuestionCreation.Web.AdminUI.Controllers
{
    public class QuestionController : BaseController
    {
        // GET: Question
        public ActionResult Index()
        {
            return View();
        }
    }
}