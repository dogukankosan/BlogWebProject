using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface IContactAboutService
	{
		void ContactAboutUpdate(ContactAbout contactAbout);
		ContactAbout GetContactAboutById(int id);
	}
}