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

        /// <summary>
        /// This method is question create.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }
    }
}