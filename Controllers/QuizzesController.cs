using Microsoft.AspNetCore.Mvc;

namespace LearnSignLanguageApp.Controllers
{
    public class QuizzesController : Controller
    {
        public IActionResult QuizModule1()
        {
            return View();
        }

        public IActionResult QuizModule1Results()
        {
            return View();
        }

        public IActionResult QuizModule2()
        {
            return View();
        }
    }
}
