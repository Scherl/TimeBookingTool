using Moq;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;
using TimeBooking.Data.Services.BusinessComponents;
using static Xunit.Assert;

namespace UnitTestTimeBooking;

public class BookingServiceTest : IClassFixture<BookingServiceTestFixture>
{
    public BookingServiceTestFixture Fixture { get; set; }
    private readonly IBookingService _context;
    private readonly Mock<IBookingService> _mockBuilder;

    public BookingServiceTest(BookingServiceTestFixture fixture)
    {
        _mockBuilder = new Mock<IBookingService>();
        _context = _mockBuilder.Object;
        Fixture = fixture;
    }

    [Fact(DisplayName = "BookingsByEmployee")]

    public async Task TestGetBookingsByEmployeeAsync()
    {
        //Arrange
        BookingBusinessComponent service = new(_context);
        var testEmployee = Fixture.TestEmployee;
        var testBooking = Fixture.TestDailyBooking;
        List<DailyBooking> bookings = new()
            {
                testBooking
            };

        _mockBuilder.Setup(x => x.GetBookingsByEmployeeAsync(testEmployee.EmployeeId, DateTime.Today))
            .ReturnsAsync(bookings);

        //Act
        var result = await service.GetBookingsByEmployeeAsync(testEmployee.EmployeeId, DateTime.Today);

        //Assert
        Single(result);
        var details = result.Single().Details;
        NotNull(details);
        Equal(3, details.Count);
        _mockBuilder.VerifyAll();
    }

    [Fact(DisplayName = "InsertBooking")]

    public async Task TestInsertBookingAsync()
    {
        //arrange
        BookingBusinessComponent service = new(_context);
        var testBooking = Fixture.TestDailyBookingEntry;

        _mockBuilder.Setup(x => x.InsertBooking(testBooking));

        //Act
        var result = await service.InsertBookingAsync(testBooking);

        //Assert
        NotEmpty(result.ToString());
        IsType<Guid>(result);
        _mockBuilder.VerifyAll();
    }

}
