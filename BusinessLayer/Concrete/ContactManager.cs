using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;
		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}
		public void ContactAdd(Contact contact)
		{
			_contactDal.Add(contact);
		}
		public void ContactRemove(Contact contact)
		{
			_contactDal.Remove(contact);
		}
		public void ContactUpdate(Contact contact)
		{
			_contactDal.Update(contact);
		}
		public List<Contact> GetAllList()
		{
			return _contactDal.ListAll();
		}
		public Contact GetContactById(int id)
		{
			return _contactDal.GetByID(id);
		}
	}
}