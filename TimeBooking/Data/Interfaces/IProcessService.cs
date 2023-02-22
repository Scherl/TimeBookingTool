using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IProcessService
    {
        Task<List<Process>> GetAllActiveProcesses();

        Task<List<Process>> GetProcessByProjecId(Guid? clientID);
    }
}
