using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IMenuTableDAL : IGenericDAL<MenuTable>
    {
        int MenuTableCount();
    }
}