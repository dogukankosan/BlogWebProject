using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ContactAboutManager : IContactAboutService
	{
		private readonly IContactAboutDal _contactAboutDal;
		public ContactAboutManager(IContactAboutDal contactAboutDal)
		{
			_contactAboutDal = contactAboutDal;
		}
		public void ContactAboutAdd(ContactAbout contactAbout)
		{
			_contactAboutDal.Add(contactAbout);
		}
		public void ContactAboutRemove(ContactAbout contactAbout)
		{
			_contactAboutDal.Remove(contactAbout);
		}
		public void ContactAboutUpdate(ContactAbout contactAbout)
		{
			_contactAboutDal.Update(contactAbout);
		}
		public List<ContactAbout> GetAllList()
		{
			return _contactAboutDal.ListAll();
		}
		public ContactAbout GetContactAboutById(int id)
		{
			return _contactAboutDal.GetByID(id);
		}
	}
}