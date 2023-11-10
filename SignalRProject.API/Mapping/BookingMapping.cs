using AutoMapper;
using SignalR.DTOLayer.DTOs.BookingDTOs;
using SignalR.EntityLayer.Concrete;

namespace SignalRProject.API.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDTO>().ReverseMap();
            CreateMap<Booking, CreateBookingDTO>().ReverseMap();
            CreateMap<Booking, GetBookingDTO>().ReverseMap();
            CreateMap<Booking, UpdateBookingDTO>().ReverseMap();
        }
    }
}