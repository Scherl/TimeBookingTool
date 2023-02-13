using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IPensumService
    {
        Task<decimal> GetWeeklyWorkloadByEmployeeAsync(Guid id);
    }
}