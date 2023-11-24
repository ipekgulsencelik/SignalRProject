using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
    {
        public EFCategoryDAL(Context context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new Context();
            return context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new Context();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new Context();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}