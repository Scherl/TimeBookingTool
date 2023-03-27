using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class dataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[] { new Guid("5bb77cfe-5ac2-46b9-9486-6158c5f22e33"), "TestStrasse 1, 3303 Jegenstorf", "TestClient 1", true, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("5bb77cfe-5ac2-46b9-9486-6158c5f22e33"));
        }
    }
}
