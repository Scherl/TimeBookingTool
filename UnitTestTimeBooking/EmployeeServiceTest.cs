using Moq;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;
using TimeBooking.Data.Services.BusinessComponents;
using static Xunit.Assert;

namespace UnitTestTimeBooking
{
    public class EmployeeServiceTest : IClassFixture<EmployeeServiceTestFixture>
    {
        public EmployeeServiceTestFixture Fixture { get; set; }
        private readonly IEmployeeService _context;
        private readonly Mock<IEmployeeService> _mockbuilder;

        public EmployeeServiceTest(EmployeeServiceTestFixture fixture)
        {
            Fixture = fixture;
            _mockbuilder = new Mock<IEmployeeService>();
            _context = _mockbuilder.Object;
           
        }

        [Fact(DisplayName = "GetEmployeeByName")]
        public async Task TestGetEmployeeByNameAsync()
        {
            //arrange
            EmployeeBusinessComponent service = new(_context);
            var employee = Fixture.Employee1;

            _mockbuilder.Setup(x => x.GetMitarbeiterByNameAsync(employee.EmployeeLastName)).ReturnsAsync(employee);

            //Act
            var result = await service.GetMitarbeiterByNameAsync("Pan");

            //Assert
            
            Equal("Pan", result.EmployeeLastName);
            _mockbuilder.VerifyAll();
        }
    }
}
