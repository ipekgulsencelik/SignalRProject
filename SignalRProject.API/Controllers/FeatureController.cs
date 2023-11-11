using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.DTOs.FeatureDTOs;
using SignalR.EntityLayer.Concrete;

namespace SignalRProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDTO>>(_featureService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDTO createFeatureDTO)
        {
            _featureService.TAdd(new Feature()
            {
                Description1 = createFeatureDTO.Description1,
                Description2 = createFeatureDTO.Description2,
                Description3 = createFeatureDTO.Description3,
                Title1 = createFeatureDTO.Title1,
                Title2 = createFeatureDTO.Title2,
                Title3 = createFeatureDTO.Title3
            });
            return Ok("Öne Çıkan Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Öne Çıkan Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDTO updateFeatureDTO)
        {
            _featureService.TUpdate(new Feature()
            {
                Description1 = updateFeatureDTO.Description1,
                Description2 = updateFeatureDTO.Description2,
                Description3 = updateFeatureDTO.Description3,
                Title1 = updateFeatureDTO.Title1,
                Title2 = updateFeatureDTO.Title2,
                Title3 = updateFeatureDTO.Title3,
                FeatureID = updateFeatureDTO.FeatureID
            });
            return Ok("Öne Çıkan Alan Bilgisi Güncellendi");
        }
    }
}