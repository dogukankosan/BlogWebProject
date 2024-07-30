using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> ListAll();
        List<T> ListAll(Expression<Func<T, bool>> filter);
        T GetByID(int id);
        void Add(T t);
        void Remove(T t);
        void Update(T t);
    }
}