using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.DTOs.CategoryDTOs;
using SignalR.EntityLayer.Concrete;

namespace SignalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDTO>>(_categoryService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_categoryService.TCategoryCount());
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDTO.CategoryName,
                Status = true
            });
            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }
        
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }
        
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryName = updateCategoryDTO.CategoryName,
                CategoryID = updateCategoryDTO.CategoryID,
                Status = updateCategoryDTO.Status
            });
            return Ok("Kategori Güncellendi");
        }
    }
}