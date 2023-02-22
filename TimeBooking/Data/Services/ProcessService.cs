using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class ProcessService : IProcessService
    {
        public readonly zeiterfassungContext Context;

        public ProcessService(zeiterfassungContext zeiterfassungContext)
        {
            Context = zeiterfassungContext;
        }

        public Task<List<Process>> GetAllActiveProcesses()
        {
            return Task.FromResult(Context.Processes.Where(x => 
                x.Active == true)
                .ToList());

        }

        public Task<List<Process>> GetProcessByProjecId(Guid? projectID)
        {
            if (projectID == null)
            {
                return Task.FromResult(new List<Process>());
            }
            return Task.FromResult(Context.Processes.Where(x =>
                x.ProjectId == projectID &&
                x.Active == true)
                .ToList());
        }
    }
}
