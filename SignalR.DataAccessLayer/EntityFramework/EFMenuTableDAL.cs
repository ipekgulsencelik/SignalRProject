using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFMenuTableDAL : GenericRepository<MenuTable>, IMenuTableDAL
    {
        public EFMenuTableDAL(Context context) : base(context)
        {
        }

        public int MenuTableCount()
        {
            using var context = new Context();
            return context.MenuTables.Count();
        }
    }
}