using System.Web.Mvc;

namespace QuestionCreation.Web.AdminUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            return View();
        }
    }
}