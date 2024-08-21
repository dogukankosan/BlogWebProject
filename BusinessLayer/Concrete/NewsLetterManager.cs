using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		private readonly INewsLetterDal _newsLetterDal;
		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			_newsLetterDal = newsLetterDal;
		}
		public List<NewsLetter> GetAllList()
		{
			throw new NotImplementedException();
		}
		public void NewsLetterAdd(NewsLetter newsLetter)
		{
			_newsLetterDal.Add(newsLetter);
		}
	}
}