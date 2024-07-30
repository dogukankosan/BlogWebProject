using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void CommentAdd(Comment comment)
        {
            _commentDal.Add(comment);
        }
        public void CommentRemove(Comment comment)
        {
            _commentDal.Remove(comment);
        }
        public void CommentUpdate(Comment comment)
        {
            _commentDal.Update(comment);
        }
        public List<Comment> GetAllList()
        {
            return _commentDal.ListAll();
        }
        public List<Comment> GetByIDList(int id)
        {
            return _commentDal.ListAll(x => x.BlogID == id);
        }
        public Comment GetCommentById(int id)
        {
            return _commentDal.GetByID(id);
        }
    }
}