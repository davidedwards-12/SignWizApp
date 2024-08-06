using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LearnSignLanguageApp.Controllers;
using LearnSignLanguageApp.Models;

namespace LearnSignLanguageApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add logic to handle user registration, such as saving to a database
                // For example:
                // _userService.RegisterUser(model);

                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add logic to handle user login, such as checking credentials
                // For example:
                // var result = _userService.LoginUser(model);
                // if (result)
                // {
                //     return RedirectToAction("Index", "Home");
                // }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(model);
        }

        // POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            // Add logic to handle user logout
            // For example:
            // _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        // GET: /Account/Profile
        [HttpGet]
        public IActionResult Profile()
        {
            // Retrieve user information to display in the profile view
            // Example: Replace this with actual logic to get user data
            var user = new ProfileViewModel
            {
                Username = "testuser",
                Email = "testuser@example.com",
                FirstName = "John",
                LastName = "Doe",
                ProfilePictureUrl = "/images/default-profile.png"
            };

            return View(user);
        }
    }
}
