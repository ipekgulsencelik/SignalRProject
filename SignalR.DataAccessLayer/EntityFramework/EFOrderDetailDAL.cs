using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFOrderDetailDAL : GenericRepository<OrderDetail>, IOrderDetailDAL
    {
        public EFOrderDetailDAL(Context context) : base(context)
        {
        }
    }
}