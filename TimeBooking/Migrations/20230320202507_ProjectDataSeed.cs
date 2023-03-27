using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class ProjectDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[] { new Guid("2d0a847d-1ce6-4a0c-ad9a-d2380f4b083c"), "TestStrasse 5, 3001 Bern", "TestClient 2", true, false });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ClientId", "ContractDuration", "IsActive", "IsFlatRate", "ProjectName", "ProjectNumber", "TotalCosts", "VAT" },
                values: new object[] { new Guid("ea9b9f27-f832-4243-ab89-cf3b3f125e5d"), new Guid("2d0a847d-1ce6-4a0c-ad9a-d2380f4b083c"), "2023", true, true, "TestProject 2", "16987", 50000.00m, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("ea9b9f27-f832-4243-ab89-cf3b3f125e5d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("2d0a847d-1ce6-4a0c-ad9a-d2380f4b083c"));

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
    }
}
