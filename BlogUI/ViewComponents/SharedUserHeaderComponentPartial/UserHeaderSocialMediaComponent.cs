using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.SharedUserHeaderComponentPartial
{
    public class UserHeaderSocialMediaComponent : ViewComponent
    {
        SocialMediaManager mediaManager = new(new EfSocialMediaRepository());
        public IViewComponentResult Invoke()
        {
            return View(mediaManager.GetSocialMediaById(1));
        }
    }
}