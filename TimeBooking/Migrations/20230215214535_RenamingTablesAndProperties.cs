using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class RenamingTablesAndProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Address = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBalance",
                columns: table => new
                {
                    EmployeeBalanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    HourBalance = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    VacationBalance = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Target = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Actual = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBalance", x => x.EmployeeBalanceId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeLastName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Entry = table.Column<DateTime>(type: "datetime", nullable: false),
                    Exit = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "T_Log",
                columns: table => new
                {
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    Thread = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Logger = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Benutzer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Computer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WorkingTime",
                columns: table => new
                {
                    WorkingTimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    WorkingTime = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    DailyWorkingTime = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValueSql: "((8))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingTime", x => x.WorkingTimeId);
                });

            migrationBuilder.CreateTable(
                name: "WorkloadReduction",
                columns: table => new
                {
                    ReductionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Reduction = table.Column<decimal>(type: "numeric(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkloadReduction", x => x.ReductionId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ProjectName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    TotalCosts = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    IsFlatRate = table.Column<bool>(type: "bit", nullable: false),
                    ContractDuration = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VAT = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Project_Client",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    OccasionLocation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ExpenseType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreditCard = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Expense_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "VacationWorkload",
                columns: table => new
                {
                    VacationWorkloadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VacationPerYear = table.Column<decimal>(type: "numeric(3,0)", nullable: false, defaultValueSql: "((25))"),
                    Workload = table.Column<decimal>(type: "numeric(3,0)", nullable: false, defaultValueSql: "((100))"),
                    ValidFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    Monday = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Thursday = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Friday = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacationWorkload", x => x.VacationWorkloadId);
                    table.ForeignKey(
                        name: "FK_VacationWorkload_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    ProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Vacation = table.Column<bool>(type: "bit", nullable: false),
                    HourlyRate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    AmountHours = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ProjektId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.ProcessId);
                    table.ForeignKey(
                        name: "FK_Process_Project",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BookingFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    BookingTill = table.Column<DateTime>(type: "datetime", nullable: false),
                    BookingComment = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Hours = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Booking_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Booking_Process",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "ProcessId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_EmployeeId",
                table: "Booking",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ProcessId",
                table: "Booking",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "UK_EmployeeBalance",
                table: "EmployeeBalance",
                columns: new[] { "EmployeeId", "Year", "Month" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_EmployeeId",
                table: "Expenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_ProjectId",
                table: "Processes",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "UK_VacationWorkload",
                table: "VacationWorkload",
                columns: new[] { "EmployeeId", "ValidFrom" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_WorkingTime",
                table: "WorkingTime",
                columns: new[] { "Year", "Month" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_WorkloadReduction",
                table: "WorkloadReduction",
                column: "Date",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "EmployeeBalance");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "T_Log");

            migrationBuilder.DropTable(
                name: "VacationWorkload");

            migrationBuilder.DropTable(
                name: "WorkingTime");

            migrationBuilder.DropTable(
                name: "WorkloadReduction");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
