using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserHeaderComponentPartial
{
	public class UserHeaderSocialMediaComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}