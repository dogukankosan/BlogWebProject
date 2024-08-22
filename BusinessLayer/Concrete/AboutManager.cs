using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;
		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}
		public void AboutUpdate(About about)
		{
			_aboutDal.Update(about);
		}
		public About GetAboutById(int id)
		{
			return _aboutDal.GetByID(id);
		}
	}
}