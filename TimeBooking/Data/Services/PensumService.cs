using Microsoft.EntityFrameworkCore;
using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class PensumService : IPensumService
    {
        public readonly zeiterfassungContext Context;

        public PensumService(zeiterfassungContext context)
        {
            Context = context;
        }

        public async Task<decimal> GetWeeklyWorkloadByEmployeeAsync(Guid Id)
        {
            var workload = await Context.FerienArbeitspensums.FirstOrDefaultAsync(x => x.MitarbeiterId == Id);

            if (workload == null)
            {
                throw new InvalidDataException("Employee not found");
            }

            var weeklyWorkload = 40 * (workload.Arbeitspensum / 100);

            return weeklyWorkload;
        }
    }
}
