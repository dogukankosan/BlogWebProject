using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager NewsLetterManager = new(new EfNewsLetterRepository());

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter newsLetter)
        {
            NewsLetterManager.NewsLetterAdd(newsLetter);
            return RedirectToAction("Index", "Home");
        }
    }
}