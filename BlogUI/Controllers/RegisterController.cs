using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[Route("KayitOl")]
	public class RegisterController : Controller
	{
		WriterManager manager=new(new EfWriterRepository());
		[Route("Islem")]
		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
		[Route("Islem")]
		[HttpPost]
		public IActionResult SignUp(Writer writer)
		{
			manager.WriterAdd(writer);
			return RedirectToAction("Islem", "KayitOl");
		}
	}
}