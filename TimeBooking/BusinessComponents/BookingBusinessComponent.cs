using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.BusinessComponents
{
    public class BookingBusinessComponent
    {
        private readonly IBookingService _bookingService;

        public BookingBusinessComponent(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public async Task<List<DailyBooking>> GetBookingsByEmployeeAsync(Guid id, DateTime date)
        {
            var bookings = await _bookingService.GetBookingsByEmployeeAsync(id, date);
                return bookings;
        }
    } //TODO: Add remaining functions!; Add Business Component for other services 
}
