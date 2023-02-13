namespace TimeBooking.Data.Models
{
    public class DailyBooking
    {
        public Guid Id { get; set; }
        public string? Weekday { get; set; } = null!;

        public DateTime Date { get; set; }


        public decimal TotalHours
        {
            get
            {
                if (Details != null && Details.Any())
                {
                    return Details.Sum(h => h.Hours);
                }
                return decimal.Zero;

            }
        }

        public List<BookingDetails>? Details { get; set; }
    }
}
