using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserAsideComponentPartial
{
	public class UserAsidePostWriterComponent : ViewComponent
	{//todo kesin sana bakmak lazım
		BlogManager blogManager = new(new EfBlogRepository());
		public IViewComponentResult Invoke(string id)
		{
			return View(blogManager.GetBlogByWriter(int.Parse(id)));
		}
	}
}