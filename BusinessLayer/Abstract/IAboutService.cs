using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface IAboutService
	{
		void AboutAdd(About blog);
		void AboutUpdate(About blog);
		void AboutRemove(About blog);
		List<About> GetAllList();
		About GetAboutById(int id);
	}
}