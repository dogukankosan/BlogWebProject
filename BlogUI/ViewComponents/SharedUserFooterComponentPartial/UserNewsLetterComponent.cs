using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserFooterComponentPartial
{
    public class UserNewsLetterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}