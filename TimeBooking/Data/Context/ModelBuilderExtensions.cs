using Microsoft.EntityFrameworkCore;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Context
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region SetUp
            var clientId1 = Guid.NewGuid();
            var clientId2 = Guid.NewGuid();
            var projectId1 = Guid.NewGuid();
            var projectId2 = Guid.NewGuid();
            var processId1 = Guid.NewGuid();
            var processId2 = Guid.NewGuid();
            var processId3 = Guid.NewGuid();
            var processId4 = Guid.NewGuid();
            var processId5 = Guid.NewGuid();
            var employeeId1 = Guid.NewGuid();
            var employeeId2 = Guid.NewGuid();
            var employeeId3 = Guid.NewGuid();
            var workingTimeId1 = Guid.NewGuid();
            var vacationWorkloadId1 = Guid.NewGuid();
            var vacationWorkloadId2 = Guid.NewGuid();
            var vacationWorkloadId3 = Guid.NewGuid();
            var expenseId1 = Guid.NewGuid();
            var expenseId2 = Guid.NewGuid();
            #endregion

            #region ClientDataInsert
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    ClientId = clientId1,
                    Address = "Gasse 1, 3303 Jegenstorf",
                    IsActive = true,
                    IsInternal = false,
                    ClientName = "TestClient 1"
                },
                new Client
                {
                    ClientId = clientId2,
                    Address = "TestStrasse 5, 3001 Bern",
                    IsActive = true,
                    IsInternal = false,
                    ClientName = "TestClient 2"
                }
            );
            #endregion

            #region ProjectDataInsert
            modelBuilder.Entity<Project>().HasData(
                new Project
                {

                    ProjectId = projectId1,
                    ProjectNumber = "12345",
                    ProjectName = "TestProject 1",
                    IsActive = true,
                    TotalCosts = 50_000.00m,
                    IsFlatRate = true,
                    ContractDuration = "2023",
                    VAT = true,
                    ClientId = clientId1
                },
                new Project
                {
                    ProjectId = projectId2,
                    ProjectNumber = "16987",
                    ProjectName = "TestProject 2",
                    IsActive = true,
                    TotalCosts = 100_000.00m,
                    IsFlatRate = true,
                    ContractDuration = "2025",
                    VAT = true,
                    ClientId = clientId2
                }
            );
            #endregion

            #region ProcessDataInsert
            modelBuilder.Entity<Process>().HasData(
                new Process
                {
                    ProcessId = processId1,
                    ProjectId = projectId1,
                    ProcessName = "TestProcess 1",
                    Active = true,
                    Vacation = false,
                    HourlyRate = 150.00m,
                    AmountHours = 100.00m

                },
                new Process
                {
                    ProcessId = processId2,
                    ProjectId = projectId1,
                    ProcessName = "TestProcess 2",
                    Active = true,
                    Vacation = false,
                    HourlyRate = 150.00m,
                    AmountHours = 20.00m

                },
                new Process
                {
                    ProcessId = processId3,
                    ProjectId = projectId1,
                    ProcessName = "TestProcess 3",
                    Active = true,
                    Vacation = false,
                    HourlyRate = 50.00m,
                    AmountHours = 20.00m

                },
                new Process
                {
                    ProcessId = processId4,
                    ProjectId = projectId2,
                    ProcessName = "TestProcess 1a",
                    Active = true,
                    Vacation = false,
                    HourlyRate = 160.00m,
                    AmountHours = 100.00m

                },
                new Process
                {
                    ProcessId = processId5,
                    ProjectId = projectId2,
                    ProcessName = "TestProcess 2a",
                    Active = true,
                    Vacation = false,
                    HourlyRate = 200.00m,
                    AmountHours = 150.00m

                });
            #endregion

            #region EmployeeDataInsert
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = employeeId1,
                    EmployeeFirstName = "Bernd",
                    EmployeeLastName = "Brot",
                    Entry = new DateTime(2019, 3, 1),
                    IsActive = true
                },
                new Employee
                {
                    EmployeeId = employeeId2,
                    EmployeeFirstName = "Anke",
                    EmployeeLastName = "Müller",
                    Entry = new DateTime(2010, 1, 1),
                    IsActive = true
                },
                new Employee
                {
                    EmployeeId = employeeId3,
                    EmployeeFirstName = "Peter",
                    EmployeeLastName = "Meier",
                    Entry = new DateTime(2015, 6, 1),
                    IsActive = false
                });
            #endregion

            #region WorkingTimeDataInsert

            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.DaysInMonth(startDate.Year, startDate.Month));
            var excludedDates = new HashSet<DateTime> { new(2023, 01, 01), new(2023, 01, 02), new(2023, 04, 07), new(2023, 04, 10), new(2023, 5, 18),
                new(2023, 5, 29), new(2023, 8, 1), new(2023, 12, 25), new(2023, 12, 26) };
            var workingTime = GetWorkingHoursPerMonth(startDate, endDate, excludedDates) * 8.00m;

            modelBuilder.Entity<WorkingTime>().HasData(
                new WorkingTime
                {
                    WorkingTimeId = workingTimeId1,
                    Year = DateTime.Now.Year,
                    Month = DateTime.Now.Month,
                    DailyWorkingTime = 8.00m,
                    WorkingTime1 = workingTime
                });

            #endregion

            #region VacationWorkloadDataInsert

            modelBuilder.Entity<VacationWorkload>().HasData(
                new VacationWorkload
                {
                    VacationWorkloadId = vacationWorkloadId1,
                    EmployeeId = employeeId1,
                    VacationPerYear = 25.00m,
                    Workload = 100.00m,
                    ValidFrom = new DateTime(2019, 3, 1),
                    Monday = true,
                    Tuesday = true,
                    Wednesday = true,
                    Thursday = true,
                    Friday = true
                },
                new VacationWorkload
                {
                    VacationWorkloadId = vacationWorkloadId2,
                    EmployeeId = employeeId2,
                    VacationPerYear = 30.00m,
                    Workload = 80.00m,
                    ValidFrom = new DateTime(2010, 1, 1),
                    Monday = true,
                    Tuesday = true,
                    Wednesday = true,
                    Thursday = true,
                    Friday = true
                },
                new VacationWorkload
                {
                    VacationWorkloadId = vacationWorkloadId3,
                    EmployeeId = employeeId3,
                    VacationPerYear = 25.00m,
                    Workload = 100.00m,
                    ValidFrom = new DateTime(2015, 6, 1),
                    Monday = true,
                    Tuesday = true,
                    Wednesday = true,
                    Thursday = true,
                    Friday = true
                }
            );

            #endregion

            #region ExpensesDataInsert

            modelBuilder.Entity<Expense>().HasData(
                new Expense
                {
                    ExpenseId = expenseId1,
                    EmployeeId = employeeId1,
                    Date = DateTime.Now.AddDays(-5),
                    Amount = 10.10m,
                    OccasionLocation = "Sitzung Bern",
                    ExpenseType = "Parkgebühr",
                    CreditCard = false,
                },
                new Expense
                {
                    ExpenseId = expenseId2,
                    EmployeeId = employeeId2,
                    Date = DateTime.Now.AddDays(-2),
                    Amount = 10.10m,
                    OccasionLocation = "Wasser",
                    ExpenseType = "Rückerstattung",
                    CreditCard = false,
                });

            #endregion
        }

        public static int GetWorkingHoursPerMonth(DateTime startDate, DateTime endDate,
            HashSet<DateTime> excludedDates)
        {
            Func<DateTime, bool> workDay = cuDate => (cuDate.DayOfWeek == DayOfWeek.Saturday ||
                                                     cuDate.DayOfWeek == DayOfWeek.Sunday ||
                                                     excludedDates.Contains(cuDate.Date));
            return Enumerable.Range(0, 1 + (endDate - startDate).Days)
                .Count(intDays => workDay(startDate.AddDays(intDays)));
        }
    }
}
