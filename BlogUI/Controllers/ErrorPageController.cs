using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error(int code)
        {
            ViewData["Title"] = "404 Hata Sayfası";
            return View();
        }
    }
}