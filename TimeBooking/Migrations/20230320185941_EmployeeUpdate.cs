using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("9102304f-4f76-40c7-85ee-6684a255fe46"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("702ec599-b72e-4755-990f-87debd9741cf"));

            migrationBuilder.DropColumn(
                name: "Exit",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[,]
                {
                    { new Guid("423ad681-b3f3-40d9-be33-d5f0ffd63927"), "TestStrasse 1, 3303 Jegenstorf", "TestClient 1", true, false },
                    { new Guid("69855592-d394-4522-84f2-66d4bc7d1b26"), "TestGasse 8, 2540 Grenchen", "TestClient 2", true, false },
                    { new Guid("fbbaac5b-1468-457e-9558-9ae2aa4752cd"), "TestStrasse 5, 3001 Bern", "TestClient 2", true, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "Entry" },
                values: new object[,]
                {
                    { new Guid("4e7560eb-8fbe-4508-8edc-4346eb0b6a69"), "Peter", "Meier", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8de4d910-7122-4c16-9870-69fa66f3feeb"), "Anke", "Müller", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9e2a17e-7207-4a47-a9af-16ebf2aa08fd"), "Bernd", "Brot", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("423ad681-b3f3-40d9-be33-d5f0ffd63927"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("69855592-d394-4522-84f2-66d4bc7d1b26"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("fbbaac5b-1468-457e-9558-9ae2aa4752cd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("4e7560eb-8fbe-4508-8edc-4346eb0b6a69"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8de4d910-7122-4c16-9870-69fa66f3feeb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f9e2a17e-7207-4a47-a9af-16ebf2aa08fd"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exit",
                table: "Employees",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[] { new Guid("9102304f-4f76-40c7-85ee-6684a255fe46"), "TestStrasse 1, 3303 Jegenstorf", "TestClient 1", true, false });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "Entry", "Exit" },
                values: new object[] { new Guid("702ec599-b72e-4755-990f-87debd9741cf"), "FirstNameTest", "LastNameTest", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
