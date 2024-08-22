using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    internal interface ISocialMediaService
    {
        void SocialMediaUpdate(SocialMedia social);
        SocialMedia GetSocialMediaById(int id);
    }
}