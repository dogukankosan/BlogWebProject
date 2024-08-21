using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[Route("Giris")]
	public class LoginController : Controller
    {
        [Route("Yap")]
        [HttpGet]
        public IActionResult Log()
        {
            return View();
        }
		[Route("Yap")]
		[HttpPost]
        public IActionResult Log(int id)
        {
            return View();
        }
    }
}