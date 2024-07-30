using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[Route("Iletisim")]
	public class ContactController : Controller
	{
		ContactManager contactManager = new(new EfContactRepository());
		[Route("Panel")]
		public IActionResult Panel()
		{
			return View();
		}
		[HttpPost]
		[Route("Add")]
		[ValidateAntiForgeryToken]
		[RequireHttps]
		public IActionResult Add(Contact ct)
		{
			contactManager.ContactAdd(ct);
			return RedirectToAction("Panel");
		}
	}
}