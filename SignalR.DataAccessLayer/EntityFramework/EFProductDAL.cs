using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        public EFProductDAL(Context context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new Context();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public decimal ProductAvgPriceByHamburger()
        {
            using var context = new Context();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
        }

        public int ProductCount()
        {
            using var context = new Context();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new Context();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new Context();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new Context();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new Context();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new Context();
            return context.Products.Average(x => x.Price);
        }
    }
}