using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[Route("Bloglar")]
	public class BlogsController : Controller
	{
		BlogManager blogManager = new(new EfBlogRepository());
		[Route("Liste")]
		public IActionResult List()
		{
			return View(blogManager.GetBlogListWithCategory());
		}
        [Route("Detay/{id:int}")]
        public IActionResult Detail(int id)
		{
            return View(blogManager.GetBlogById(id));
        }
	}
}