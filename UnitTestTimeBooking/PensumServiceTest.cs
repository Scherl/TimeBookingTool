using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Services.BusinessComponents;
using Xunit.Sdk;
using static Xunit.Assert;

namespace UnitTestTimeBooking
{
    public class PensumServiceTest
    {
        private readonly IPensumService _context;
        private readonly Mock<IPensumService> _mockbuilder;

        public PensumServiceTest()
        {
            _mockbuilder = new Mock<IPensumService>();
            _context = _mockbuilder.Object;
        }

        [Fact(DisplayName = "WeeklyWorkloadByEmployee")]
        public async Task TestWeeklyWOrkloadByEmployee()
        {
            //arrange
            var workload = 0.8m;
            var id = Guid.NewGuid();
            PensumBusinessComponent service = new(_context);

            _mockbuilder.Setup(x => x.GetWeeklyWorkloadByEmployeeAsync(id)).ReturnsAsync(workload);

            // act
            var result = await service.GetWeeklyWorkloadByEmployeeAsync(id);

            //assert
            IsType<decimal>(result);
            Single(result.ToString());
            _mockbuilder.VerifyAll();
        }
    }
}
