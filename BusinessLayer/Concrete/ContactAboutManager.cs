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
		public void ContactAboutUpdate(ContactAbout contactAbout)
		{
			_contactAboutDal.Update(contactAbout);
		}
		public ContactAbout GetContactAboutById(int id)
		{
			return _contactAboutDal.GetByID(id);
		}
	}
}