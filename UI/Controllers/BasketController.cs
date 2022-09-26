using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
