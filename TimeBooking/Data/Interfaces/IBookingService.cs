using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IBookingService
    {
        /// <summary>
        /// Returns the time entries for the selected week by employee id
        /// </summary>
        /// <param name="id"> employee id</param>
        /// <param name="date"> selected date by user</param>
        /// <returns>List with bookings of selected week</returns>
        public Task<List<DailyBooking>> GetBookingsByEmployeeAsync(Guid id, DateTime date);

        /// <summary>
        /// Method to insert a new daily time booking
        /// </summary>
        /// <param name="booking">object with all time entry information</param>
        /// <returns></returns>
        public Task InsertBooking(DailyBookingEntry booking);
    }
}


