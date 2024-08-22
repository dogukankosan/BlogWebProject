using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public SocialMedia GetSocialMediaById(int id)
        {
            return _socialMediaDal.GetByID(id);
        }
        public void SocialMediaUpdate(SocialMedia social)
        {
            _socialMediaDal.Update(social);
        }
    }
}