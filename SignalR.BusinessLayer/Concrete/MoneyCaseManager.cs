using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Concrete;

namespace SignalR.BusinessLayer.Concrete
{
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCaseDAL _moneyCaseDAL;

        public MoneyCaseManager(IMoneyCaseDAL moneyCaseDAL)
        {
            _moneyCaseDAL = moneyCaseDAL;
        }

        public void TAdd(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public MoneyCase TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MoneyCase> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal TTotalMoneyCaseAmount()
        {
            return _moneyCaseDAL.TotalMoneyCaseAmount();
        }

        public void TUpdate(MoneyCase entity)
        {
            throw new NotImplementedException();
        }
    }
}
