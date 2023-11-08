namespace SignalR.DTOLayer.DTOs.DiscountDTOs
{
    public class UpdateDiscountDTO
    {
        public int DiscountID { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}