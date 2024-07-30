using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserFooterComponentPartial
{
	public class UserFooterSocialMediaComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}