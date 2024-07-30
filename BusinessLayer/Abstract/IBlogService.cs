using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface IBlogService
	{
		List<Blog> GetBlogListWithCategory();
		void BlogAdd(Blog blog);
		void BlogUpdate(Blog blog);
		void BlogRemove(Blog blog);
		List<Blog> GetAllList();
		Blog GetBlogById(int id);
	}
}