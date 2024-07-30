using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context = new();
        public void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }
        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public List<T> ListAll()
        {
            return _context.Set<T>().ToList();
        }
        public List<T> ListAll(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }
        public void Remove(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }
        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}