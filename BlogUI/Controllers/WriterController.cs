using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    [Route("Yazar")]
    public class WriterController : Controller
    {
        [Route("Panel")]
        public IActionResult Panel()
        {
            return View();
        }
    }
}
