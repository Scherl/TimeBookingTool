using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBooking.Data.Models;

namespace UnitTestTimeBooking
{
    public class CustomerServiceTextFixture
    {
        public Client Customer1 { get; set; } = _customer1;
        public Client Customer2 { get; set; } = _customer2;


        private static readonly Client _customer1 = new()
        {
            ClientId = Guid.NewGuid(),
            ClientName = "Test Client 1a",
            Address = "TestStreet1a, 10119 Berlin, Deutschland",
            IsActive = true,
            IsInternal = false
        };
        private static readonly Client _customer2 = new()
        {
            ClientId = Guid.NewGuid(),
            ClientName = "Test Client 2a",
            Address = "TestStreet 2a, 3001 Bern, Switzerland",
            IsActive = false,
            IsInternal = false
        };


    }
}
