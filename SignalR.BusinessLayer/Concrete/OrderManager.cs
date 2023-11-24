using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Concrete;

namespace SignalR.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDAL _orderDAL;

        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }

        public int TActiveOrderCount()
        {
            return _orderDAL.ActiveOrderCount();
        }

        public void TAdd(Order entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal TLastOrderPrice()
        {
            return _orderDAL.LastOrderPrice();
        }

        public int TTotalOrderCount()
        {
            return _orderDAL.TotalOrderCount();
        }

        public void TUpdate(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}