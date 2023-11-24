using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DTOLayer.DTOs.ProductDTO;
using SignalR.EntityLayer.Concrete;

namespace SignalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDTO>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }

        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }

        [HttpGet("ProductAvgPriceByHamburger")]
        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.TProductAvgPriceByHamburger());
        }

        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new Context();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageURL = y.ImageURL,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDTO createProductDTO)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDTO.Description,
                ImageURL = createProductDTO.ImageURL,
                Price = createProductDTO.Price,
                ProductName = createProductDTO.ProductName,
                ProductStatus = createProductDTO.ProductStatus,
                CategoryID = createProductDTO.CategoryID
            });
            return Ok("Ürün Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün Bilgisi Silindi");
        }
        
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            _productService.TUpdate(new Product()
            {
                Description = updateProductDTO.Description,
                ImageURL = updateProductDTO.ImageURL,
                Price = updateProductDTO.Price,
                ProductName = updateProductDTO.ProductName,
                ProductStatus = updateProductDTO.ProductStatus,
                ProductID = updateProductDTO.ProductID,
                CategoryID = updateProductDTO.CategoryID
            });
            return Ok("Ürün Bilgisi Güncellendi");
        }
    }
}