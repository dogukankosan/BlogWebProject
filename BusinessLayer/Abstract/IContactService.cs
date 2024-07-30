using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface IContactService
	{
		void ContactAdd(Contact contact);
		void ContactUpdate(Contact contact);
		void ContactRemove(Contact contact);
		List<Contact> GetAllList();
		Contact GetContactById(int id);
	}
}