using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IProjectService
    {
        Task<List<Project>> GetAllActiveProjects();

        Task<List<Project>> GetProjectsByCustomerID(Guid? clientID);
    }
}
