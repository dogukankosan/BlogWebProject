using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}