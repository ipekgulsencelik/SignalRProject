using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFMoneyCaseDAL : GenericRepository<MoneyCase>, IMoneyCaseDAL
    {
        public EFMoneyCaseDAL(Context context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new Context();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}