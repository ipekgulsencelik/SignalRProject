using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Concrete;

namespace SignalR.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public int TActiveCategoryCount()
        {
            return _categoryDAL.ActiveCategoryCount();
        }

        public void TAdd(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public int TCategoryCount()
        {
            return _categoryDAL.CategoryCount();
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDAL.GetListAll();
        }

        public int TPassiveCategoryCount()
        {
            return _categoryDAL.PassiveCategoryCount();
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}