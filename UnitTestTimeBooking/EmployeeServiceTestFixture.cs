using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBooking.Data.Models;

namespace UnitTestTimeBooking
{
    public class EmployeeServiceTestFixture
    {
        public Employee Employee1 = _employee1;
        public Employee Employee2 = _employee2;
        public Employee Employee3 = _employee3;
        
        private static readonly Employee _employee1 = new()
        {
            EmployeeId = Guid.NewGuid(),
            EmployeeFirstName = "Peter",
            EmployeeLastName = "Pan",
            IsActive = true,
            Entry = new DateTime(2019, 1, 1)
        };

        private static readonly Employee _employee2 = new()
        {
            EmployeeId = Guid.NewGuid(),
            EmployeeFirstName = "Hans",
            EmployeeLastName = "August",
            IsActive = true,
            Entry = new DateTime(2022, 5, 1)
        }; 
        
        private static readonly Employee _employee3 = new()
        {
            EmployeeId = Guid.NewGuid(),
            EmployeeFirstName = "Marie",
            EmployeeLastName = "Meier",
            IsActive = true,
            Entry = new DateTime(2018, 4, 1)
        };
    }
}
