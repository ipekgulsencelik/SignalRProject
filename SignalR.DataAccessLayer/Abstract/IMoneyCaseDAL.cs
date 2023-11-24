using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IMoneyCaseDAL : IGenericDAL<MoneyCase>
    {
        decimal TotalMoneyCaseAmount();
    }
}