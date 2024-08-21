using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[Route("Hakkinda")]
	public class AboutController : Controller
	{
		AboutManager aboutManager = new(new EfAboutRepository());
		[Route("Bilgi")]
		public IActionResult List()
		{
			ViewData["Title"] = "Hakkinda";
			return View(aboutManager.GetAllList());
		}
	}
}