using SignalR.EntityLayer.Concrete;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        int TTotalOrderCount();
        int TActiveOrderCount();
        decimal TLastOrderPrice();
    }
}