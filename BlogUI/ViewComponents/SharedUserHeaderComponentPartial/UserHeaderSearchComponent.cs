using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserHeaderComponentPartial
{
	public class UserHeaderSearchComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}