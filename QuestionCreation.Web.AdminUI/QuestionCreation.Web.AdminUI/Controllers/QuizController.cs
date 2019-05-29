using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using QuestionCreation.Web.Business.IService;
using QuestionCreation.Web.Data.Entities;

namespace QuestionCreation.Web.AdminUI.Controllers
{
    public class QuizController : BaseController
    {
        #region Ctor
        private readonly IQuizService _quizService;

        public QuizController( IQuizService quizService)
        {
            _quizService = quizService;
        }
        #endregion

        // GET: Question
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This method is quiz create.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Question create page.
        /// </summary>
        /// <param name="quiz"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Create(Quiz quiz)
        {

            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Model not valid.";
                return View(quiz);
            }

            try
            {
                await _quizService.Create(quiz);
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Question update page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }

        /// <summary>
        /// This method is quiz updated.
        /// </summary>
        /// <param name="quiz"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Update(Quiz quiz)
        {
            try
            {
                await _quizService.Update(quiz);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }
    }
}