﻿using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IBookingService
    {
        public  Task<List<DailyBooking>> GetBookingsByEmployeeAsync(Guid id, DateTime date);
        public Task InsertBooking(DailyBookingEntry booking);
    }
}


