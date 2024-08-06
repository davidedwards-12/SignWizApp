using LearnSignLanguageApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnSignLanguageApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Sends user to he Index page (here it is the home screen)
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Sends user to the Privacy page
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Sends user to the Learn page
        /// </summary>
        /// <returns></returns>
        public IActionResult Learn()
        {
            return View();
        }

        /// <summary>
        /// Sends user to the Games page
        /// </summary>
        /// <returns></returns>
        public IActionResult Games()
        {
            return View();
        }

        /// <summary>
        /// Sends user to the Quizzes page
        /// </summary>
        /// <returns></returns>
        public IActionResult Quizzes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}