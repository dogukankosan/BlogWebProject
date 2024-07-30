using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager CategoryManager = new(new EfCategoryRepository());
        public IActionResult List()
        {
            return View(CategoryManager.GetAllList());
        }
    }
}