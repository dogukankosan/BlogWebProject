using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.ContactUserComponentPartial
{
	public class UserContactAddComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}