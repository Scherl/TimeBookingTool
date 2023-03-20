using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("5bb77cfe-5ac2-46b9-9486-6158c5f22e33"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[] { new Guid("93703d24-2108-4eb8-855a-47ea7bd34a9a"), "TestStrasse 1, 3303 Jegenstorf", "TestClient 1", true, false });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "Entry", "Exit" },
                values: new object[] { new Guid("476d1037-e2c9-4e4a-aeee-307a6f25742c"), "FirstNameTest", "LastNameTest", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("93703d24-2108-4eb8-855a-47ea7bd34a9a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("476d1037-e2c9-4e4a-aeee-307a6f25742c"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[] { new Guid("5bb77cfe-5ac2-46b9-9486-6158c5f22e33"), "TestStrasse 1, 3303 Jegenstorf", "TestClient 1", true, false });
        }
    }
}
