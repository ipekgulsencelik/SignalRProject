﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
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

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDTO createProductDTO)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDTO.Description,
                ImageURL = createProductDTO.ImageURL,
                Price = createProductDTO.Price,
                ProductName = createProductDTO.ProductName,
                ProductStatus = createProductDTO.ProductStatus
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
                ProductID = updateProductDTO.ProductID
            });
            return Ok("Ürün Bilgisi Güncellendi");
        }
    }
}