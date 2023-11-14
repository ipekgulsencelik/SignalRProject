﻿namespace SignalRProject.UI.DTOs.BookingDTOs
{
	public class UpdateBookingDTO
	{
		public int BookingID { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Mail { get; set; }
		public int PersonCount { get; set; }
		public DateTime Date { get; set; }
	}
}