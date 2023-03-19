using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Process>> GetAllActiveProcesses()
        {
            return await Context.Processes.Where(x => 
                x.Active == true)
                .ToListAsync();

        }

        public async Task<List<Process>> GetProcessByProjecId(Guid? projectID)
        {
            if (projectID == null)
            {
                return  new List<Process>();
            }
            return await Context.Processes.Where(x =>
                x.ProjectId == projectID &&
                x.Active == true)
                .ToListAsync();
        }
    }
}
