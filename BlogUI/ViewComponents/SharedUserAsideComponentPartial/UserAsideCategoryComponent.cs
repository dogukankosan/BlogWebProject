using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserAsideComponentPartial
{
	public class UserAsideCategoryComponent : ViewComponent
	{
		CategoryManager categoryManager = new(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			return View(categoryManager.GetAllList());
		}
	}
}