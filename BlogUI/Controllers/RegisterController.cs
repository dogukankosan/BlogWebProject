using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[Route("KayitOl")]
	public class RegisterController : Controller
	{
		WriterManager manager = new(new EfWriterRepository());
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
			WriterValidation wr = new ();
			ValidationResult result = wr.Validate(writer);
			if (result.IsValid)
			{
				manager.WriterAdd(writer);
				return RedirectToAction("Islem", "KayitOl");
			}
			else
			{
				foreach (ValidationFailure? item in result.Errors)
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				return View();
			}
		}
	}
}