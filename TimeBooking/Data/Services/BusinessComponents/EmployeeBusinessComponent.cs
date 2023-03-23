using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services.BusinessComponents
{
    public class EmployeeBusinessComponent
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeBusinessComponent(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<Employee> GetMitarbeiterByNameAsync(string name)
        {
            var employee = await _employeeService.GetMitarbeiterByNameAsync(name);
                return employee;
        }
    }
}
