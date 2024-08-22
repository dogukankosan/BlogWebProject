using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface IAboutService
	{
		void AboutUpdate(About about);
		About GetAboutById(int id);
	}
}