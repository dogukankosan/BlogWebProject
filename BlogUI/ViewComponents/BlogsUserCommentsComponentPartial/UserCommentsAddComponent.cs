using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.BlogsUserCommentsComponentPartial
{
    public class UserCommentsAddComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}