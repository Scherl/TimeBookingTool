namespace TimeBooking.Data.Models
{
    public class DailyBookingEntry
    {
       public Guid? EmployeeId { get; set; }
        public Guid? CustomerId { get; set; }
        public string? Project { get; set; }
        public string? Activity { get; set; }
        public DateTime? BookingDate { get; set; }
        public decimal? Hours { get; set; }
        public string? Comment { get; set; }
    }
}
