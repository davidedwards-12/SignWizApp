using Microsoft.AspNetCore.Mvc;

namespace LearnSignLanguageApp.Controllers
{
    public class LearnController : Controller
    {
        public IActionResult Module1()
        {
            return View();
        }
    }
}
