using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDAL : IGenericDAL<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}