using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserFooterComponentPartial
{
	public class UserFooterLatestPostsComponent:ViewComponent
	{
		BlogManager manager = new(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			return View(manager.GetAllList().TakeLast(3).ToList());
		}
	}
}