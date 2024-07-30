using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface IContactAboutService
	{
		void ContactAboutAdd(ContactAbout contactAbout);
		void ContactAboutUpdate(ContactAbout contactAbout);
		void ContactAboutRemove(ContactAbout contactAbout);
		List<ContactAbout> GetAllList();
		ContactAbout GetContactAboutById(int id);
	}
}