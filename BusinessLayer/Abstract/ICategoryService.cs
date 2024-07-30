using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    internal interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryUpdate(Category category);
        void CategoryRemove(Category category);
        List<Category> GetAllList();
        Category GetCategoryById(byte id);
    }
}