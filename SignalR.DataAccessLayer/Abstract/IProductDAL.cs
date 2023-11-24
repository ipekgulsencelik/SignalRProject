using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDAL : IGenericDAL<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCount();
        int ProductCountByCategoryNameHamburger();
        int ProductCountByCategoryNameDrink();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
        decimal ProductAvgPriceByHamburger();
    }
}