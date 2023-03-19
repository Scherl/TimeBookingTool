using Microsoft.EntityFrameworkCore;
using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly zeiterfassungContext Context;

        public EmployeeService(zeiterfassungContext context)
        {
            Context = context;
        }

        public async Task<Employee> GetMitarbeiterByNameAsync(string name)
        {
            var mitarbeiter = await Context.Employees.Include(v => v.VacationWorkloads).FirstOrDefaultAsync(x => x.EmployeeLastName == name);

            if (mitarbeiter == null)
            {
                throw new InvalidDataException("Employee not found");
            }

            return mitarbeiter;
        }

        
    }
}
