using AutoMapper;
using SignalR.DTOLayer.DTOs.AboutDTOs;
using SignalR.EntityLayer.Concrete;

namespace SignalRProject.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDTO>().ReverseMap();
            CreateMap<About, CreateAboutDTO>().ReverseMap();
            CreateMap<About, GetAboutDTO>().ReverseMap();
            CreateMap<About, UpdateAboutDTO>().ReverseMap();
        }
    }
}