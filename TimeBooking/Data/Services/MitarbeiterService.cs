using Microsoft.EntityFrameworkCore;
using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class MitarbeiterService : IMitarbeiterService
    {
        public readonly zeiterfassungContext Context;

        public MitarbeiterService(zeiterfassungContext context)
        {
            Context = context;
        }

        public async Task<Mitarbeiter> GetMitarbeiterByNameAsync(string name)
        {
            var mitarbeiter = await Context.Mitarbeiters.FirstOrDefaultAsync(x => x.MitarbeiterName == name);

            if (mitarbeiter == null)
            {
                throw new InvalidDataException("Employee not found");
            }

            return mitarbeiter;
        }

        
    }
}
