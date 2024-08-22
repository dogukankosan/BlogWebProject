using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserFooterComponentPartial
{
    public class UserFooterSocialMediaComponent : ViewComponent
    {
        SocialMediaManager SocialMediaManager = new(new EfSocialMediaRepository());
        public IViewComponentResult Invoke()
        {
            return View(SocialMediaManager.GetSocialMediaById(1));
        }
    }
}