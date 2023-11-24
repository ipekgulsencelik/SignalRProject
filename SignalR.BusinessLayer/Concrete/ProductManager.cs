using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Concrete;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TAdd(Product entity)
        {
            _productDAL.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productDAL.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDAL.GetListAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
            return _productDAL.GetProductsWithCategories();
        }

        public decimal TProductAvgPriceByHamburger()
        {
            return _productDAL.ProductAvgPriceByHamburger();
        }

        public int TProductCount()
        {
            return _productDAL.ProductCount();
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _productDAL.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _productDAL.ProductCountByCategoryNameHamburger();
        }

        public string TProductNameByMaxPrice()
        {
            return _productDAL.ProductNameByMaxPrice();
        }

        public string TProductNameByMinPrice()
        {
            return _productDAL.ProductNameByMinPrice();
        }

        public decimal TProductPriceAvg()
        {
            return _productDAL.ProductPriceAvg();
        }

        public void TUpdate(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}