using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IBuchungsService
    {
        public  Task<List<DailyBooking>> GetBookingsByEmployeeAsync(Guid id, DateTime date);
        public Task CreateProduct(DailyBooking booking);
    }
}