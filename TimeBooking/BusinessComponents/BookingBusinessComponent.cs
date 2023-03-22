﻿using TimeBooking.Data.Interfaces;
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

        public async Task InsertBooking(DailyBookingEntry booking)
        {
            await _bookingService.InsertBooking(booking);
        }


    } //TODO:  Add Business Component for other services 
}
