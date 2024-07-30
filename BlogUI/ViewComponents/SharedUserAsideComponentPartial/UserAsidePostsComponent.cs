using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserAsideComponentPartial
{
	public class UserAsidePostsComponent : ViewComponent
	{
		BlogManager BlogManager = new(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			return View(BlogManager.GetAllList());
		}
	}
}