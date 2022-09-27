using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using UI.ApiService;
using UI.Models;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginApiService _loginService;
        public LoginController(LoginApiService loginApiService)
        {
            _loginService = loginApiService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM nesne)
        {
            if (await _loginService.GetUser(nesne.UserName, nesne.Password))
            {
                if (nesne.UserName != null && nesne.Password != null)
                {

                    List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, nesne.UserName)
            };

                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal userPrincipal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(userPrincipal);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }
    }
}
