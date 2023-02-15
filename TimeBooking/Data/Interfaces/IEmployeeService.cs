using TimeBooking.Data.Models;

namespace TimeBooking.Data.Interfaces
{
    public interface IEmployeeService
    {
       public Task<Employee> GetMitarbeiterByNameAsync(string name);

    }
}
