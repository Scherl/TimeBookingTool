using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeNewUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[,]
                {
                    { new Guid("e802c72c-0673-494f-8f02-6cab7e2642a4"), "TestStrasse 1, 3303 Jegenstorf", "TestClient 1", true, false },
                    { new Guid("efd1245f-fa00-41d1-84eb-618403c70e08"), "TestStrasse 5, 3001 Bern", "TestClient 2", true, false },
                    { new Guid("f08ac686-e346-4df2-8b3e-af439302ed16"), "TestGasse 8, 2540 Grenchen", "TestClient 2", true, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "Entry", "IsActive" },
                values: new object[,]
                {
                    { new Guid("4628ca10-011f-4b7c-85c8-beb681aaeaf8"), "Peter", "Meier", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("71db956e-0360-46ad-9224-2aa99ff59de0"), "Anke", "Müller", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("98871c1a-f708-4b1a-8f18-add442982ed8"), "Bernd", "Brot", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("e802c72c-0673-494f-8f02-6cab7e2642a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("efd1245f-fa00-41d1-84eb-618403c70e08"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("f08ac686-e346-4df2-8b3e-af439302ed16"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("4628ca10-011f-4b7c-85c8-beb681aaeaf8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("71db956e-0360-46ad-9224-2aa99ff59de0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("98871c1a-f708-4b1a-8f18-add442982ed8"));

            migrationBuilder.DropColumn(
                name: "IsActive",
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
    }
}
