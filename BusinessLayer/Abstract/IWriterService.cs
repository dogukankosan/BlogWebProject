using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface IWriterService
	{
		void WriterAdd(Writer writer);
		void WriterUpdate(Writer writer);
		void WriterRemove(Writer writer);
		List<Writer> GetAllList();
		Writer GetWriterById(int id);
	}
}