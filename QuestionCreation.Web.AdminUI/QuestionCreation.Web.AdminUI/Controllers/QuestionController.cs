using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using QuestionCreation.Web.Business.IService;
using QuestionCreation.Web.Data.Entities;

namespace QuestionCreation.Web.AdminUI.Controllers
{
    public class QuestionController : BaseController
    {

        #region Ctor
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        } 
        #endregion

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

        /// <summary>
        /// Question create page.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Create(Question question)
        {

            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Model not valid.";
                return View(question);
            }

            try
            {
                await _questionService.Create(question);
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
        /// This method is question updated.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Update(Question question)
        {
            try
            {
                await _questionService.Update(question);

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