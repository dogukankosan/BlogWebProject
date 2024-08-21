using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface INewsLetterService
	{
		List<NewsLetter> GetAllList();
		void NewsLetterAdd(NewsLetter newsLetter);
	}
} 