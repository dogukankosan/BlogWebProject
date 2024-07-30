using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	internal interface ICommentService
	{
		void CommentAdd(Comment comment);
		void CommentUpdate(Comment comment);
		void CommentRemove(Comment comment);
		List<Comment> GetAllList();
        List<Comment> GetByIDList(int id);
        Comment GetCommentById(int id);
	}
}