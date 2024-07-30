using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new(new EfCommentRepository());
		public IActionResult List()
		{
			return View();
		}
		public IActionResult Details(int id)
		{
			return View();
		}
		public IActionResult Add(Comment comment)
		{
			int id = comment.BlogID;
			commentManager.CommentAdd(comment);
			return RedirectToAction("Detay", "Bloglar", new { id });
		}
	}
}