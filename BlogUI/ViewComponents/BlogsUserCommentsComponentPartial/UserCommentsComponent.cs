using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.BlogsUserCommentsComponentPartial
{
    public class UserCommentsComponent : ViewComponent
    {
        CommentManager manager = new(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            return View(manager.GetByIDList(id));
        }
    }
}