using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		private readonly IBlogDal _blogDal;
		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}
		public void BlogAdd(Blog blog)
		{
			_blogDal.Add(blog);
		}
		public void BlogRemove(Blog blog)
		{
			_blogDal.Remove(blog);
		}
		public void BlogUpdate(Blog blog)
		{
			_blogDal.Update(blog);
		}
		public List<Blog> GetAllList()
		{
			return _blogDal.ListAll();
		}
		public Blog GetBlogById(int id)
		{
			return _blogDal.GetByID(id);
		}
		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();	
		}
	}
}