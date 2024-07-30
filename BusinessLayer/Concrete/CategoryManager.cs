using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void CategoryAdd(Category category)
        {
            _categoryDal.Add(category);
        }
        public void CategoryRemove(Category category)
        {
            _categoryDal.Remove(category);
        }
        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }
        public List<Category> GetAllList()
        {
            return _categoryDal.ListAll();
        }
        public Category GetCategoryById(byte id)
        {
            return _categoryDal.GetByID(id);
        }
    }
}