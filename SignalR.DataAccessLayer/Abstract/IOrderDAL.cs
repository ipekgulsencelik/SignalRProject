using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IOrderDAL : IGenericDAL<Order>
    {
        int TotalOrderCount();
        int ActiveOrderCount();
        decimal LastOrderPrice();
    }
}