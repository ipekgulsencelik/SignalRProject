namespace SignalR.DTOLayer.DTOs.BookingDTOs
{
    public class CreateBookingDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}