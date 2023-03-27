using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class BookingCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("8d80e514-e7b1-4b1c-b2f8-c68ecfddf321"), "TestStrasse 5, 3001 Bern", "TestClient 2", true, false },
                    { new Guid("fdbae1d7-75ef-4fea-9bf2-23a289ad8c9d"), "Gasse 1, 3303 Jegenstorf", "TestClient 1", true, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeFirstName", "EmployeeLastName", "Entry", "IsActive" },
                values: new object[,]
                {
                    { new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), "Bernd", "Brot", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("a008b4c0-88ca-47c1-8630-291d9ee15853"), "Peter", "Meier", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("a58e04bc-6126-4eec-a014-42a73c076322"), "Anke", "Müller", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.InsertData(
                table: "WorkingTime",
                columns: new[] { "WorkingTimeId", "DailyWorkingTime", "Month", "WorkingTime", "Year" },
                values: new object[] { new Guid("2694dd4d-08bc-4225-9a68-800ff82fab09"), 8.00m, 3, 64.00m, 2023 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "CreditCard", "Date", "EmployeeId", "ExpenseType", "OccasionLocation" },
                values: new object[,]
                {
                    { new Guid("629bfa9d-7b6b-42e3-823f-a92d98fead7d"), 10.10m, false, new DateTime(2023, 3, 15, 23, 8, 54, 687, DateTimeKind.Local).AddTicks(143), new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), "Parkgebühr", "Sitzung Bern" },
                    { new Guid("661814e4-e401-4b62-8e71-1ab9f798dc51"), 10.10m, false, new DateTime(2023, 3, 18, 23, 8, 54, 687, DateTimeKind.Local).AddTicks(147), new Guid("a58e04bc-6126-4eec-a014-42a73c076322"), "Rückerstattung", "Wasser" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ClientId", "ContractDuration", "IsActive", "IsFlatRate", "ProjectName", "ProjectNumber", "TotalCosts", "VAT" },
                values: new object[,]
                {
                    { new Guid("2dae18c8-e528-4870-b691-f1df3e7e5319"), new Guid("fdbae1d7-75ef-4fea-9bf2-23a289ad8c9d"), "2023", true, true, "TestProject 1", "12345", 50000.00m, true },
                    { new Guid("44c56bd8-c2cb-4bfa-b7fa-800188d59fa6"), new Guid("8d80e514-e7b1-4b1c-b2f8-c68ecfddf321"), "2025", true, true, "TestProject 2", "16987", 100000.00m, true }
                });

            migrationBuilder.InsertData(
                table: "VacationWorkload",
                columns: new[] { "VacationWorkloadId", "EmployeeId", "Friday", "Monday", "Thursday", "Tuesday", "VacationPerYear", "ValidFrom", "Wednesday", "Workload" },
                values: new object[,]
                {
                    { new Guid("0ac23686-0de0-4a02-ae9b-913a030e2ed0"), new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), true, true, true, true, 25.00m, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m },
                    { new Guid("288a7251-6b98-4bd9-84ce-7a0d4b89b5f9"), new Guid("a58e04bc-6126-4eec-a014-42a73c076322"), true, true, true, true, 30.00m, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 80.00m },
                    { new Guid("66c0f1df-bdb2-4f9e-9258-cd4f1c0935ff"), new Guid("a008b4c0-88ca-47c1-8630-291d9ee15853"), true, true, true, true, 25.00m, new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "ProcessId", "Active", "AmountHours", "HourlyRate", "ProcessName", "ProjectId", "ProjektId", "Vacation" },
                values: new object[,]
                {
                    { new Guid("174793b3-cd31-412f-ab1c-97edfa65aa90"), true, 100.00m, 150.00m, "TestProcess 1", new Guid("2dae18c8-e528-4870-b691-f1df3e7e5319"), null, false },
                    { new Guid("81a7e9bd-d189-44ac-9721-01f5e0d77712"), true, 100.00m, 160.00m, "TestProcess 1a", new Guid("44c56bd8-c2cb-4bfa-b7fa-800188d59fa6"), null, false },
                    { new Guid("8cebca44-c691-4be2-b6d3-ab9d742f8cf2"), true, 20.00m, 50.00m, "TestProcess 3", new Guid("2dae18c8-e528-4870-b691-f1df3e7e5319"), null, false },
                    { new Guid("a944d35d-67ba-4475-b8ef-c262113c8905"), true, 20.00m, 150.00m, "TestProcess 2", new Guid("2dae18c8-e528-4870-b691-f1df3e7e5319"), null, false },
                    { new Guid("be1e8984-5cd3-43b1-b5a7-53a7010d52a5"), true, 150.00m, 200.00m, "TestProcess 2a", new Guid("44c56bd8-c2cb-4bfa-b7fa-800188d59fa6"), null, false }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookingComment", "BookingDate", "BookingFrom", "BookingTill", "EmployeeId", "Hours", "ProcessId" },
                values: new object[,]
                {
                    { new Guid("0716a8e8-d57f-4682-a790-e67850011549"), "Test Comment 5", new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), true, new Guid("be1e8984-5cd3-43b1-b5a7-53a7010d52a5") },
                    { new Guid("171e5fae-a9cb-4c80-b09b-0bbdb088c925"), "Test Comment 2", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), true, new Guid("a944d35d-67ba-4475-b8ef-c262113c8905") },
                    { new Guid("2d17732c-1141-470a-977b-7861fa28e719"), "Test Comment 1", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), true, new Guid("174793b3-cd31-412f-ab1c-97edfa65aa90") },
                    { new Guid("518d09bd-7a7d-4e22-86b4-abfe0a9c768d"), "Test Comment 4", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), true, new Guid("81a7e9bd-d189-44ac-9721-01f5e0d77712") },
                    { new Guid("961816cf-3951-4622-8e25-03cd6e1b47bb"), "Test Comment 3", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"), true, new Guid("8cebca44-c691-4be2-b6d3-ab9d742f8cf2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("0716a8e8-d57f-4682-a790-e67850011549"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("171e5fae-a9cb-4c80-b09b-0bbdb088c925"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("2d17732c-1141-470a-977b-7861fa28e719"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("518d09bd-7a7d-4e22-86b4-abfe0a9c768d"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: new Guid("961816cf-3951-4622-8e25-03cd6e1b47bb"));

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: new Guid("629bfa9d-7b6b-42e3-823f-a92d98fead7d"));

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: new Guid("661814e4-e401-4b62-8e71-1ab9f798dc51"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("0ac23686-0de0-4a02-ae9b-913a030e2ed0"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("288a7251-6b98-4bd9-84ce-7a0d4b89b5f9"));

            migrationBuilder.DeleteData(
                table: "VacationWorkload",
                keyColumn: "VacationWorkloadId",
                keyValue: new Guid("66c0f1df-bdb2-4f9e-9258-cd4f1c0935ff"));

            migrationBuilder.DeleteData(
                table: "WorkingTime",
                keyColumn: "WorkingTimeId",
                keyValue: new Guid("2694dd4d-08bc-4225-9a68-800ff82fab09"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("757f0271-5819-44f3-a4f4-2a4a97149c71"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a008b4c0-88ca-47c1-8630-291d9ee15853"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a58e04bc-6126-4eec-a014-42a73c076322"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("174793b3-cd31-412f-ab1c-97edfa65aa90"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("81a7e9bd-d189-44ac-9721-01f5e0d77712"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("8cebca44-c691-4be2-b6d3-ab9d742f8cf2"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("a944d35d-67ba-4475-b8ef-c262113c8905"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: new Guid("be1e8984-5cd3-43b1-b5a7-53a7010d52a5"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("2dae18c8-e528-4870-b691-f1df3e7e5319"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("44c56bd8-c2cb-4bfa-b7fa-800188d59fa6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("8d80e514-e7b1-4b1c-b2f8-c68ecfddf321"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("fdbae1d7-75ef-4fea-9bf2-23a289ad8c9d"));

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
    }
}
