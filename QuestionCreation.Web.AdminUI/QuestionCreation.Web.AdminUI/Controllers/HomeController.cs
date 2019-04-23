using System.Web.Mvc;

namespace QuestionCreation.Web.AdminUI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}