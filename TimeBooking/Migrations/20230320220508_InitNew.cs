using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class InitNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("25f9ab13-eea8-4aae-b6e8-515d9bcac845"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("4cbd53a3-0c37-464f-9e2b-e1924e0356eb"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("51472296-fe7b-447d-ba62-82304d9ab39a"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("9673faba-b29d-41b6-a6b4-2761fbae57de"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("ceac0f09-32bb-499a-8ed7-78fe59ea6802"));

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: new Guid("583debc6-37a6-44b0-a2fe-cd6058effa41"));

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: new Guid("c123114f-f4d0-48b2-a3ae-08e6b2bbe651"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("129fb348-0f8a-45cd-98a4-0c50e75e46ec"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("1dd7e460-cf2c-48a4-869f-7db92d12c02a"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("49c645fa-a2c1-467f-b484-98b926d2383e"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "WorkingTimeId",
                keyValue: new Guid("8930a6ec-c9f3-44ad-ba23-7bc2f3128603"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("782802a7-5d9c-4c29-8df2-10775d3739b1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8f102974-76d1-4af3-b6c3-1c2a0528fb9f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("0160d9b1-e598-4c37-b813-37574a2eef5d"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("32a7c9e8-1b1a-4586-b484-86e87bd76cae"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("5497d4ae-6fe0-420e-86b5-9ca955ce3297"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("aa98befe-2552-4ff2-90c1-b01d22042458"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("e6ebad07-2b6c-4d4e-9e6d-4d863e3cb765"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("e7d85c93-f24b-44f4-8fe8-1d71d9fe59f0"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("094802f2-3c40-4ecc-acca-dba1e61ae515"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("0d6a03d7-f061-472f-8254-bf542e445b06"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[,]
                {
                    { new Guid("5ddf9eb0-1795-4292-a22a-dc55653c05dd"), "TestStrasse 5, 3001 Bern", "TestClient 2", true, false },
                    { new Guid("e00bb1ca-cb83-47eb-844d-bbb671f9bc72"), "Gasse 1, 3303 Jegenstorf", "TestClient 1", true, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "Entry", "IsActive" },
                values: new object[,]
                {
                    { new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), "Bernd", "Brot", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("862f9484-c0be-41d7-ae0c-c048a0e7635a"), "Peter", "Meier", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("cdbc3b32-2db5-4f1d-b948-9dc079905a16"), "Anke", "Müller", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "WorkingTimeId", "DailyWorkingTime", "Month", "WorkingTime", "Year" },
                values: new object[] { new Guid("9655cbc3-446f-4dee-ba1b-4ab6a59f5355"), 8.00m, 3, 64.00m, 2023 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "CreditCard", "Date", "EmployeeId", "ExpenseType", "OccasionLocation" },
                values: new object[,]
                {
                    { new Guid("64d5b83b-722a-4b06-919e-ce1feabbcb99"), 10.10m, false, new DateTime(2023, 3, 18, 23, 5, 8, 561, DateTimeKind.Local).AddTicks(5145), new Guid("cdbc3b32-2db5-4f1d-b948-9dc079905a16"), "Rückerstattung", "Wasser" },
                    { new Guid("bd06e76a-7e25-4907-b6d1-8477cfe4d524"), 10.10m, false, new DateTime(2023, 3, 15, 23, 5, 8, 561, DateTimeKind.Local).AddTicks(5141), new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), "Parkgebühr", "Sitzung Bern" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ClientId", "ContractDuration", "IsActive", "IsFlatRate", "ProjectName", "ProjectNumber", "TotalCosts", "VAT" },
                values: new object[,]
                {
                    { new Guid("5f3c0273-3ae3-44fc-8233-34edcd9618bb"), new Guid("e00bb1ca-cb83-47eb-844d-bbb671f9bc72"), "2023", true, true, "TestProject 1", "12345", 50000.00m, true },
                    { new Guid("6a5786d0-8ae8-4f93-ba83-0c1a58062227"), new Guid("5ddf9eb0-1795-4292-a22a-dc55653c05dd"), "2025", true, true, "TestProject 2", "16987", 100000.00m, true }
                });

            migrationBuilder.InsertData(
                table: "VacationWorkload",
                columns: new[] { "VacationWorkloadId", "EmployeeId", "Friday", "Monday", "Thursday", "Tuesday", "VacationPerYear", "ValidFrom", "Wednesday", "Workload" },
                values: new object[,]
                {
                    { new Guid("5fbf6104-6f60-4ade-9868-ea41ea96d779"), new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), true, true, true, true, 25.00m, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m },
                    { new Guid("77afffd2-05ae-4de3-862c-24651d9132a8"), new Guid("cdbc3b32-2db5-4f1d-b948-9dc079905a16"), true, true, true, true, 30.00m, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 80.00m },
                    { new Guid("83f1c87a-3e60-4c07-8a05-c51054286d86"), new Guid("862f9484-c0be-41d7-ae0c-c048a0e7635a"), true, true, true, true, 25.00m, new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "ProcessId", "Active", "AmountHours", "HourlyRate", "ProcessName", "ProjectId", "ProjektId", "Vacation" },
                values: new object[,]
                {
                    { new Guid("2b9a6e48-fc88-4716-9759-983d7ee25436"), true, 150.00m, 200.00m, "TestProcess 2a", new Guid("6a5786d0-8ae8-4f93-ba83-0c1a58062227"), null, false },
                    { new Guid("3ca600dc-97a9-4db8-8e47-54dd6c454cc5"), true, 100.00m, 160.00m, "TestProcess 1a", new Guid("6a5786d0-8ae8-4f93-ba83-0c1a58062227"), null, false },
                    { new Guid("a92896df-e7cd-4ce2-811b-80146b0dbfbd"), true, 100.00m, 150.00m, "TestProcess 1", new Guid("5f3c0273-3ae3-44fc-8233-34edcd9618bb"), null, false },
                    { new Guid("bfd293c8-1493-43bf-9d7e-2938c3dc4c2b"), true, 20.00m, 150.00m, "TestProcess 2", new Guid("5f3c0273-3ae3-44fc-8233-34edcd9618bb"), null, false },
                    { new Guid("e8259679-73b7-4b9f-9121-509e6f3208b7"), true, 20.00m, 50.00m, "TestProcess 3", new Guid("5f3c0273-3ae3-44fc-8233-34edcd9618bb"), null, false }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookingComment", "BookingDate", "BookingFrom", "BookingTill", "EmployeeId", "Hours", "ProcessId" },
                values: new object[,]
                {
                    { new Guid("0ee09c9b-99a0-454e-8606-7f68a96d48b0"), "Test Comment 3", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), true, new Guid("e8259679-73b7-4b9f-9121-509e6f3208b7") },
                    { new Guid("3b765367-eba3-4039-981b-659aa57788a7"), "Test Comment 4", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), true, new Guid("3ca600dc-97a9-4db8-8e47-54dd6c454cc5") },
                    { new Guid("52a2bbdc-43f5-4b36-9f9f-b9fadd020e5e"), "Test Comment 5", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), true, new Guid("2b9a6e48-fc88-4716-9759-983d7ee25436") },
                    { new Guid("75445522-4848-4128-9eef-83485b963ed3"), "Test Comment 2", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), true, new Guid("bfd293c8-1493-43bf-9d7e-2938c3dc4c2b") },
                    { new Guid("862850f2-a7d4-4a50-9400-6ea361db4f23"), "Test Comment 1", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"), true, new Guid("a92896df-e7cd-4ce2-811b-80146b0dbfbd") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("0ee09c9b-99a0-454e-8606-7f68a96d48b0"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("3b765367-eba3-4039-981b-659aa57788a7"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("52a2bbdc-43f5-4b36-9f9f-b9fadd020e5e"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("75445522-4848-4128-9eef-83485b963ed3"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("862850f2-a7d4-4a50-9400-6ea361db4f23"));

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: new Guid("64d5b83b-722a-4b06-919e-ce1feabbcb99"));

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: new Guid("bd06e76a-7e25-4907-b6d1-8477cfe4d524"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("5fbf6104-6f60-4ade-9868-ea41ea96d779"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("77afffd2-05ae-4de3-862c-24651d9132a8"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("83f1c87a-3e60-4c07-8a05-c51054286d86"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "WorkingTimeId",
                keyValue: new Guid("9655cbc3-446f-4dee-ba1b-4ab6a59f5355"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("85c4ef17-913e-43fe-a0ed-3a1468f93cde"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("862f9484-c0be-41d7-ae0c-c048a0e7635a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("cdbc3b32-2db5-4f1d-b948-9dc079905a16"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("2b9a6e48-fc88-4716-9759-983d7ee25436"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("3ca600dc-97a9-4db8-8e47-54dd6c454cc5"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("a92896df-e7cd-4ce2-811b-80146b0dbfbd"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("bfd293c8-1493-43bf-9d7e-2938c3dc4c2b"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("e8259679-73b7-4b9f-9121-509e6f3208b7"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("5f3c0273-3ae3-44fc-8233-34edcd9618bb"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("6a5786d0-8ae8-4f93-ba83-0c1a58062227"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("5ddf9eb0-1795-4292-a22a-dc55653c05dd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("e00bb1ca-cb83-47eb-844d-bbb671f9bc72"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "ClientName", "IsActive", "IsInternal" },
                values: new object[,]
                {
                    { new Guid("094802f2-3c40-4ecc-acca-dba1e61ae515"), "TestStrasse 5, 3001 Bern", "TestClient 2", true, false },
                    { new Guid("0d6a03d7-f061-472f-8254-bf542e445b06"), "Gasse 1, 3303 Jegenstorf", "TestClient 1", true, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "Entry", "IsActive" },
                values: new object[,]
                {
                    { new Guid("782802a7-5d9c-4c29-8df2-10775d3739b1"), "Peter", "Meier", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("8f102974-76d1-4af3-b6c3-1c2a0528fb9f"), "Anke", "Müller", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), "Bernd", "Brot", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "WorkingTimeId", "DailyWorkingTime", "Month", "WorkingTime", "Year" },
                values: new object[] { new Guid("8930a6ec-c9f3-44ad-ba23-7bc2f3128603"), 8.00m, 3, 64.00m, 2023 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "CreditCard", "Date", "EmployeeId", "ExpenseType", "OccasionLocation" },
                values: new object[,]
                {
                    { new Guid("583debc6-37a6-44b0-a2fe-cd6058effa41"), 10.10m, false, new DateTime(2023, 3, 18, 23, 2, 1, 150, DateTimeKind.Local).AddTicks(8216), new Guid("8f102974-76d1-4af3-b6c3-1c2a0528fb9f"), "Rückerstattung", "Wasser" },
                    { new Guid("c123114f-f4d0-48b2-a3ae-08e6b2bbe651"), 10.10m, false, new DateTime(2023, 3, 15, 23, 2, 1, 150, DateTimeKind.Local).AddTicks(8211), new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), "Parkgebühr", "Sitzung Bern" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ClientId", "ContractDuration", "IsActive", "IsFlatRate", "ProjectName", "ProjectNumber", "TotalCosts", "VAT" },
                values: new object[,]
                {
                    { new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"), new Guid("0d6a03d7-f061-472f-8254-bf542e445b06"), "2023", true, true, "TestProject 1", "12345", 50000.00m, true },
                    { new Guid("e7d85c93-f24b-44f4-8fe8-1d71d9fe59f0"), new Guid("094802f2-3c40-4ecc-acca-dba1e61ae515"), "2025", true, true, "TestProject 2", "16987", 100000.00m, true }
                });

            migrationBuilder.InsertData(
                table: "VacationWorkload",
                columns: new[] { "VacationWorkloadId", "EmployeeId", "Friday", "Monday", "Thursday", "Tuesday", "VacationPerYear", "ValidFrom", "Wednesday", "Workload" },
                values: new object[,]
                {
                    { new Guid("129fb348-0f8a-45cd-98a4-0c50e75e46ec"), new Guid("8f102974-76d1-4af3-b6c3-1c2a0528fb9f"), true, true, true, true, 30.00m, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 80.00m },
                    { new Guid("1dd7e460-cf2c-48a4-869f-7db92d12c02a"), new Guid("782802a7-5d9c-4c29-8df2-10775d3739b1"), true, true, true, true, 25.00m, new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m },
                    { new Guid("49c645fa-a2c1-467f-b484-98b926d2383e"), new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), true, true, true, true, 25.00m, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "ProcessId", "Active", "AmountHours", "HourlyRate", "ProcessName", "ProjectId", "ProjektId", "Vacation" },
                values: new object[,]
                {
                    { new Guid("0160d9b1-e598-4c37-b813-37574a2eef5d"), true, 100.00m, 150.00m, "TestProcess 1", new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"), null, false },
                    { new Guid("32a7c9e8-1b1a-4586-b484-86e87bd76cae"), true, 100.00m, 160.00m, "TestProcess 1a", new Guid("e7d85c93-f24b-44f4-8fe8-1d71d9fe59f0"), null, false },
                    { new Guid("5497d4ae-6fe0-420e-86b5-9ca955ce3297"), true, 20.00m, 50.00m, "TestProcess 3", new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"), null, false },
                    { new Guid("aa98befe-2552-4ff2-90c1-b01d22042458"), true, 150.00m, 200.00m, "TestProcess 2a", new Guid("e7d85c93-f24b-44f4-8fe8-1d71d9fe59f0"), null, false },
                    { new Guid("e6ebad07-2b6c-4d4e-9e6d-4d863e3cb765"), true, 20.00m, 150.00m, "TestProcess 2", new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"), null, false }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookingComment", "BookingDate", "BookingFrom", "BookingTill", "EmployeeId", "Hours", "ProcessId" },
                values: new object[,]
                {
                    { new Guid("25f9ab13-eea8-4aae-b6e8-515d9bcac845"), "Test Comment 5", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), true, new Guid("aa98befe-2552-4ff2-90c1-b01d22042458") },
                    { new Guid("4cbd53a3-0c37-464f-9e2b-e1924e0356eb"), "Test Comment 3", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), true, new Guid("5497d4ae-6fe0-420e-86b5-9ca955ce3297") },
                    { new Guid("51472296-fe7b-447d-ba62-82304d9ab39a"), "Test Comment 2", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), true, new Guid("e6ebad07-2b6c-4d4e-9e6d-4d863e3cb765") },
                    { new Guid("9673faba-b29d-41b6-a6b4-2761fbae57de"), "Test Comment 4", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), true, new Guid("32a7c9e8-1b1a-4586-b484-86e87bd76cae") },
                    { new Guid("ceac0f09-32bb-499a-8ed7-78fe59ea6802"), "Test Comment 1", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"), true, new Guid("0160d9b1-e598-4c37-b813-37574a2eef5d") }
                });
        }
    }
}
