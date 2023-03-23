using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;
using TimeBooking.Data.Services;

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
            return  await _bookingService.GetBookingsByEmployeeAsync(id, date);
              
        }

        public async Task<Guid> InsertBookingAsync(DailyBookingEntry booking)
        {
           return await _bookingService.InsertBooking(booking);
        }


    } //TODO:  Add Business Component for other services 
}
