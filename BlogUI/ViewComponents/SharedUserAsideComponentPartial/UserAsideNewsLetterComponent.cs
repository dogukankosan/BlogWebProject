using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserAsideComponentPartial
{
    public class UserAsideNewsLetterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}