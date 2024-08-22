using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserFooterComponentPartial
{
	public class UserFooterAboutUsComponent : ViewComponent
	{   //todo bunu düzelt
		AboutManager manager = new(new EfAboutRepository());
		public IViewComponentResult Invoke()
		{
			return View(manager.GetAboutById(1));
		}
	}
}