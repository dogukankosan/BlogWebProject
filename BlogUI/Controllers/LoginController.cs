using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
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
		public async Task<IActionResult> Log(Writer p)
		{
			Context c = new();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (datavalue != null)
			{
				List<Claim> claims = new()
				{
					new Claim(ClaimTypes.Name,datavalue.WriterMail)
				};
				ClaimsIdentity userIdentity =new (claims,"a");
				ClaimsPrincipal principal = new (userIdentity);	
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Panel", "Yazar");
			}
			return View();
		}
	}
}