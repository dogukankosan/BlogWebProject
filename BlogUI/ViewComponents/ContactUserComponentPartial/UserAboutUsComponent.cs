using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.ContactUserComponentPartial
{
	public class UserAboutUsComponent : ViewComponent
	{
		ContactAboutManager contactAboutManager = new(new EfContactAboutRepository());
		public IViewComponentResult Invoke()
		{
			return View(contactAboutManager.GetContactAboutById(1));
		}
	}
}