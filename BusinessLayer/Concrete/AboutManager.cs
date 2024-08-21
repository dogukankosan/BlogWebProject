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
		public void AboutAdd(About blog)
		{
			_aboutDal.Add(blog);
		}
		public void AboutRemove(About blog)
		{
			_aboutDal.Remove(blog);
		}
		public void AboutUpdate(About blog)
		{
			_aboutDal.Update(blog);
		}
		public About GetAboutById(int id)
		{
			return _aboutDal.GetByID(id);
		}
		public List<About> GetAllList()
		{
			return _aboutDal.ListAll();
		}
	}
}