using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFOrderDAL : GenericRepository<Order>, IOrderDAL
    {
        public EFOrderDAL(Context context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new Context();
            return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new Context();
            return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
        }

        public int TotalOrderCount()
        {
            using var context = new Context();
            return context.Orders.Count();
        }
    }
}