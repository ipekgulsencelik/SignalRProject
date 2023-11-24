using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface ICategoryDAL : IGenericDAL<Category>
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
    }
}