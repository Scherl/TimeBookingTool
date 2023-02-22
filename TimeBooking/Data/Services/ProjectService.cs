using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class ProjectService : IProjectService
    {
        public readonly zeiterfassungContext Context;

        public ProjectService(zeiterfassungContext zeiterfassungContext)
        {
            Context = zeiterfassungContext;
        }

        public Task<List<Project>> GetAllActiveProjects()
        {
            return Task.FromResult(Context.Projects.Where(x => 
                x.IsActive == true)
                .ToList());

        }

        public Task<List<Project>> GetProjectsByCustomerID(Guid? clientID)
        {
            if (clientID == null)
            {
                return Task.FromResult(new List<Project>());
            }
            return Task.FromResult(Context.Projects.Where(x =>
                x.ClientId == clientID &&
                x.IsActive == true)
                .ToList());
        }
    }
}
