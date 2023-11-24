using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Concrete;

namespace SignalR.BusinessLayer.Concrete
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDAL _menuTableDAL;

        public MenuTableManager(IMenuTableDAL menuTableDAL)
        {
            _menuTableDAL = menuTableDAL;
        }

        public void TAdd(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public MenuTable TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MenuTable> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public int TMenuTableCount()
        {
            return _menuTableDAL.MenuTableCount();
        }

        public void TUpdate(MenuTable entity)
        {
            throw new NotImplementedException();
        }
    }
}
