namespace TimeBooking.Data.Models
{
    public class BookingDetails
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public decimal Hours { get; set; }
        public string? Project { get; set; }
        public DateTime BuchungsDatum { get; set; }
        

    }
}
