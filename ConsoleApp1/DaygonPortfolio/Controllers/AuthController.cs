using Microsoft.AspNetCore.Mvc;
using DaygonPortfolio.Models;

namespace DaygonPortfolio.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            if (model.Username == "admin" && model.Password == "admin123")
            {
                HttpContext.Session.SetString("IsLoggedIn", "true");
                HttpContext.Session.SetString("Username", model.Username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid hardcoded credentials.";
            return View("~/Views/Account/Login.cshtml", model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Auth");
        }
    }
}