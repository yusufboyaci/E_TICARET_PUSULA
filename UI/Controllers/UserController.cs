using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
