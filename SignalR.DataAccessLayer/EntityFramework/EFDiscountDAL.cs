using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFDiscountDAL : GenericRepository<Discount>, IDiscountDAL
    {
        public EFDiscountDAL(Context context) : base(context)
        {
        }
    }
}