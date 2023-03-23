using TimeBooking.Data.Models;

namespace UnitTestTimeBooking
{
    public class BookingServiceTestFixture
    {

        public Employee TestEmployee = _employee;
        public Client TestClient = _client;
        public Project TestProject = _project;
        public Process TestProcess = _process;
        public Booking TestBooking = _booking;
        public DailyBooking TestDailyBooking = _dailyBooking;
        public DailyBookingEntry TestDailyBookingEntry = _dailyBookingEntry;


        private static readonly Employee _employee = new()
        {
            EmployeeId = Guid.NewGuid(),
            EmployeeFirstName = "Hans",
            EmployeeLastName = "August",
            Entry = new DateTime(2019, 6, 1),
            IsActive = true
        };

        private static readonly Client _client = new()
        {
            ClientId = Guid.NewGuid(),
            ClientName = "Test Client 1",
            Address = "TestStreet1, 3001 Bern, Switzerland",
            IsActive = true,
            IsInternal = false
        };

        private static readonly Project _project = new()
        {
            ProjectId = Guid.NewGuid(),
            ProjectName = "Test Project 1",
            ProjectNumber = "123",
            ClientId = _client.ClientId,
            IsActive = true,
            IsFlatRate = false,
            ContractDuration = "2024",
            TotalCosts = 4000.00m

        };

        private static readonly Process _process = new()
        {
            ProcessId = Guid.NewGuid(),
            ProcessName = "Test Process 1",
            Active = true,
            HourlyRate = 150.00m,
            AmountHours = 1000.00m,
            ProjectId = _project.ProjectId,
            Vacation = false
        };

        private static readonly Booking _booking = new()
        {
            BookingId = Guid.NewGuid(),
            EmployeeId = _employee!.EmployeeId,
            ProcessId = _process.ProcessId,
            BookingDate = DateTime.Today,
            BookingFrom = DateTime.Today,
            BookingTill = DateTime.Today.AddHours(1),
            BookingComment = "Test Booking 1",
            Hours = false

        };
        private static readonly Booking _booking2 = new()
        {
            BookingId = Guid.NewGuid(),
            EmployeeId = _employee!.EmployeeId,
            ProcessId = _process.ProcessId,
            BookingDate = DateTime.Today,
            BookingFrom = DateTime.Today,
            BookingTill = DateTime.Today.AddHours(3),
            BookingComment = "Test Booking 2",
            Hours = false

        };

        private static readonly Booking _booking3 = new()
        {
            BookingId = Guid.NewGuid(),
            EmployeeId = _employee!.EmployeeId,
            ProcessId = _process.ProcessId,
            BookingDate = DateTime.Today,
            BookingFrom = DateTime.Today,
            BookingTill = DateTime.Today.AddHours(2),
            BookingComment = "Test Booking 3",
            Hours = false

        };

        private static readonly List<BookingDetails> _bookingDetails = new ()
        {
            new BookingDetails
            {

                Id = Guid.NewGuid(),
                BuchungsDatum = DateTime.Today,
                Hours = 1m,
                Project = _project.ProjectName,
                Title = _booking.BookingComment

            },
            new BookingDetails
            {

                Id = Guid.NewGuid(),
                BuchungsDatum = DateTime.Today,
                Hours = 3m,
                Project = _project.ProjectName,
                Title = _booking2.BookingComment

            },
            new BookingDetails
            {

                Id = Guid.NewGuid(),
                BuchungsDatum = DateTime.Today,
                Hours = 2m,
                Project = _project.ProjectName,
                Title = _booking3.BookingComment

            },
        };
        

        private static readonly DailyBooking _dailyBooking = new()
        {
            Id = Guid.NewGuid(),
            Date = DateTime.Today,
            Weekday = "Monday",
            Details = _bookingDetails
        };

        private static readonly DailyBookingEntry _dailyBookingEntry = new()
        {
            EmployeeId = _employee.EmployeeId,
            CustomerId = _client.ClientId,
            ProcessId = _process.ProcessId,
            ProjectId = _project.ProjectId,
            BookingDate = DateTime.Today,
            Hours = 5.5m,
            Comment = "Test Comment Booking"
        };
    }
}
