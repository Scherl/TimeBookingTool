using Moq;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;
using TimeBooking.Data.Services.BusinessComponents;

namespace UnitTestTimeBooking;

public class CustomerServiceTest : IClassFixture<CustomerServiceTextFixture>
{
    public CustomerServiceTextFixture Fixture { get; set; }
    private readonly ICustomerService _context;
    private readonly Mock<ICustomerService> _mockbuilder;

    public CustomerServiceTest(CustomerServiceTextFixture fixture)
    {
        Fixture = fixture;
        _mockbuilder = new Mock<ICustomerService>();
        _context = _mockbuilder.Object;
        
    }

    [Fact(DisplayName = "GetActiveCustomers")]

    public async Task GetAllActiveCustomers()
    {
        //Arrange
        CustomerBusinessComponent service = new(_context);
        var customer = Fixture.Customer1;
        var customer2 = Fixture.Customer2;
        List<Client> clients = new()
        {
            customer, customer2
        };

        _mockbuilder.Setup(x => x.GetAllActiveCustomers()).ReturnsAsync(clients.FindAll(x => x.IsActive == true));

        //Act
        var result = await service.GetAllActiveCustomers();

        //Assert
        Equals(1, result.Count);
        _mockbuilder.VerifyAll();
    }
}

