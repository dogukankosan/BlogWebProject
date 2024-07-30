using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		private readonly IWriterDal _dal;
		public WriterManager(IWriterDal dal)
		{
			_dal = dal;
		}
		public List<Writer> GetAllList()
		{
			return _dal.ListAll();
		}
		public Writer GetWriterById(int id)
		{
			return _dal.GetByID(id);
		}
		public void WriterAdd(Writer writer)
		{
			_dal.Add(writer);
		}
		public void WriterRemove(Writer writer)
		{
			_dal.Remove(writer);
		}
		public void WriterUpdate(Writer writer)
		{
			_dal.Update(writer);
		}
	}
}