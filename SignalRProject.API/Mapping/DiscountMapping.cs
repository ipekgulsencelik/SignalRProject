using AutoMapper;
using SignalR.DTOLayer.DTOs.DiscountDTOs;
using SignalR.EntityLayer.Concrete;

namespace SignalRProject.API.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDTO>().ReverseMap();
            CreateMap<Discount, CreateDiscountDTO>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDTO>().ReverseMap();
            CreateMap<Discount, GetDiscountDTO>().ReverseMap();
        }
    }
}
