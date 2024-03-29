﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeBooking.Data.Context;

#nullable disable

namespace TimeBooking.Migrations
{
    [DbContext(typeof(zeiterfassungContext))]
    [Migration("20230320220201_DataSeedUpdate")]
    partial class DataSeedUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TimeBooking.Data.Models.ActiveClient", b =>
                {
                    b.Property<string>("Adresse")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<bool?>("Aktiv")
                        .HasColumnType("bit");

                    b.Property<bool?>("Intern")
                        .HasColumnType("bit");

                    b.Property<Guid?>("KundeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KundeName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.ToTable((string)null);

                    b.ToView("ActiveClients", (string)null);
                });

            modelBuilder.Entity("TimeBooking.Data.Models.ActiveProcesses", b =>
                {
                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<bool>("IsActiv")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVacation")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProcessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable((string)null);

                    b.ToView("ActiveProcesses", (string)null);
                });

            modelBuilder.Entity("TimeBooking.Data.Models.ActiveProject", b =>
                {
                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientNummer")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ContractDuration")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsActiv")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsFlatRate")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjectName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal?>("TotalCosts")
                        .HasColumnType("numeric(18, 2)");

                    b.ToTable((string)null);

                    b.ToView("ActiveProjects", (string)null);
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Booking", b =>
                {
                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BookingComment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("BookingFrom")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("BookingTill")
                        .HasColumnType("datetime");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Hours")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProcessId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookingId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProcessId");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            BookingId = new Guid("ceac0f09-32bb-499a-8ed7-78fe59ea6802"),
                            BookingComment = "Test Comment 1",
                            BookingDate = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            BookingFrom = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            BookingTill = new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc),
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            Hours = true,
                            ProcessId = new Guid("0160d9b1-e598-4c37-b813-37574a2eef5d")
                        },
                        new
                        {
                            BookingId = new Guid("51472296-fe7b-447d-ba62-82304d9ab39a"),
                            BookingComment = "Test Comment 2",
                            BookingDate = new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            BookingFrom = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            BookingTill = new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc),
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            Hours = true,
                            ProcessId = new Guid("e6ebad07-2b6c-4d4e-9e6d-4d863e3cb765")
                        },
                        new
                        {
                            BookingId = new Guid("4cbd53a3-0c37-464f-9e2b-e1924e0356eb"),
                            BookingComment = "Test Comment 3",
                            BookingDate = new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            BookingFrom = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            BookingTill = new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc),
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            Hours = true,
                            ProcessId = new Guid("5497d4ae-6fe0-420e-86b5-9ca955ce3297")
                        },
                        new
                        {
                            BookingId = new Guid("9673faba-b29d-41b6-a6b4-2761fbae57de"),
                            BookingComment = "Test Comment 4",
                            BookingDate = new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            BookingFrom = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            BookingTill = new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc),
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            Hours = true,
                            ProcessId = new Guid("32a7c9e8-1b1a-4586-b484-86e87bd76cae")
                        },
                        new
                        {
                            BookingId = new Guid("25f9ab13-eea8-4aae-b6e8-515d9bcac845"),
                            BookingComment = "Test Comment 5",
                            BookingDate = new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            BookingFrom = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            BookingTill = new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc),
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            Hours = true,
                            ProcessId = new Guid("aa98befe-2552-4ff2-90c1-b01d22042458")
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Client", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsInternal")
                        .HasColumnType("bit");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = new Guid("0d6a03d7-f061-472f-8254-bf542e445b06"),
                            Address = "Gasse 1, 3303 Jegenstorf",
                            ClientName = "TestClient 1",
                            IsActive = true,
                            IsInternal = false
                        },
                        new
                        {
                            ClientId = new Guid("094802f2-3c40-4ecc-acca-dba1e61ae515"),
                            Address = "TestStrasse 5, 3001 Bern",
                            ClientName = "TestClient 2",
                            IsActive = true,
                            IsInternal = false
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Entry")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            EmployeeFirstName = "Bernd",
                            EmployeeLastName = "Brot",
                            Entry = new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true
                        },
                        new
                        {
                            EmployeeId = new Guid("8f102974-76d1-4af3-b6c3-1c2a0528fb9f"),
                            EmployeeFirstName = "Anke",
                            EmployeeLastName = "Müller",
                            Entry = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true
                        },
                        new
                        {
                            EmployeeId = new Guid("782802a7-5d9c-4c29-8df2-10775d3739b1"),
                            EmployeeFirstName = "Peter",
                            EmployeeLastName = "Meier",
                            Entry = new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.EmployeeBalance", b =>
                {
                    b.Property<Guid>("EmployeeBalanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal>("Actual")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("HourBalance")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<decimal>("Target")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal>("VacationBalance")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("EmployeeBalanceId");

                    b.HasIndex(new[] { "EmployeeId", "Year", "Month" }, "UK_EmployeeBalance")
                        .IsUnique();

                    b.ToTable("EmployeeBalance");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Expense", b =>
                {
                    b.Property<Guid>("ExpenseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<bool>("CreditCard")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExpenseType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OccasionLocation")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ExpenseId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            ExpenseId = new Guid("c123114f-f4d0-48b2-a3ae-08e6b2bbe651"),
                            Amount = 10.10m,
                            CreditCard = false,
                            Date = new DateTime(2023, 3, 15, 23, 2, 1, 150, DateTimeKind.Local).AddTicks(8211),
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            ExpenseType = "Parkgebühr",
                            OccasionLocation = "Sitzung Bern"
                        },
                        new
                        {
                            ExpenseId = new Guid("583debc6-37a6-44b0-a2fe-cd6058effa41"),
                            Amount = 10.10m,
                            CreditCard = false,
                            Date = new DateTime(2023, 3, 18, 23, 2, 1, 150, DateTimeKind.Local).AddTicks(8216),
                            EmployeeId = new Guid("8f102974-76d1-4af3-b6c3-1c2a0528fb9f"),
                            ExpenseType = "Rückerstattung",
                            OccasionLocation = "Wasser"
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.InactiveClient", b =>
                {
                    b.Property<string>("Address")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInternal")
                        .HasColumnType("bit");

                    b.ToTable((string)null);

                    b.ToView("InactiveClients", (string)null);
                });

            modelBuilder.Entity("TimeBooking.Data.Models.InactiveProcesses", b =>
                {
                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVacation")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProcessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable((string)null);

                    b.ToView("InactiveProcesses", (string)null);
                });

            modelBuilder.Entity("TimeBooking.Data.Models.InactiveProject", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContractDuration")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProjectNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("TotalCosts")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<bool>("isFlatRate")
                        .HasColumnType("bit");

                    b.ToTable((string)null);

                    b.ToView("InactiveProjects", (string)null);
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Process", b =>
                {
                    b.Property<Guid>("ProcessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("AmountHours")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProjektId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Vacation")
                        .HasColumnType("bit");

                    b.HasKey("ProcessId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Processes");

                    b.HasData(
                        new
                        {
                            ProcessId = new Guid("0160d9b1-e598-4c37-b813-37574a2eef5d"),
                            Active = true,
                            AmountHours = 100.00m,
                            HourlyRate = 150.00m,
                            ProcessName = "TestProcess 1",
                            ProjectId = new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"),
                            Vacation = false
                        },
                        new
                        {
                            ProcessId = new Guid("e6ebad07-2b6c-4d4e-9e6d-4d863e3cb765"),
                            Active = true,
                            AmountHours = 20.00m,
                            HourlyRate = 150.00m,
                            ProcessName = "TestProcess 2",
                            ProjectId = new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"),
                            Vacation = false
                        },
                        new
                        {
                            ProcessId = new Guid("5497d4ae-6fe0-420e-86b5-9ca955ce3297"),
                            Active = true,
                            AmountHours = 20.00m,
                            HourlyRate = 50.00m,
                            ProcessName = "TestProcess 3",
                            ProjectId = new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"),
                            Vacation = false
                        },
                        new
                        {
                            ProcessId = new Guid("32a7c9e8-1b1a-4586-b484-86e87bd76cae"),
                            Active = true,
                            AmountHours = 100.00m,
                            HourlyRate = 160.00m,
                            ProcessName = "TestProcess 1a",
                            ProjectId = new Guid("e7d85c93-f24b-44f4-8fe8-1d71d9fe59f0"),
                            Vacation = false
                        },
                        new
                        {
                            ProcessId = new Guid("aa98befe-2552-4ff2-90c1-b01d22042458"),
                            Active = true,
                            AmountHours = 150.00m,
                            HourlyRate = 200.00m,
                            ProcessName = "TestProcess 2a",
                            ProjectId = new Guid("e7d85c93-f24b-44f4-8fe8-1d71d9fe59f0"),
                            Vacation = false
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Project", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContractDuration")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsFlatRate")
                        .HasColumnType("bit");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProjectNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("TotalCosts")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<bool>("VAT")
                        .HasColumnType("bit");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = new Guid("4ad45f3c-bac8-4ef5-bc61-7cdd70b383c0"),
                            ClientId = new Guid("0d6a03d7-f061-472f-8254-bf542e445b06"),
                            ContractDuration = "2023",
                            IsActive = true,
                            IsFlatRate = true,
                            ProjectName = "TestProject 1",
                            ProjectNumber = "12345",
                            TotalCosts = 50000.00m,
                            VAT = true
                        },
                        new
                        {
                            ProjectId = new Guid("e7d85c93-f24b-44f4-8fe8-1d71d9fe59f0"),
                            ClientId = new Guid("094802f2-3c40-4ecc-acca-dba1e61ae515"),
                            ContractDuration = "2025",
                            IsActive = true,
                            IsFlatRate = true,
                            ProjectName = "TestProject 2",
                            ProjectNumber = "16987",
                            TotalCosts = 100000.00m,
                            VAT = true
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.T_Log", b =>
                {
                    b.Property<string>("Benutzer")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Computer")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<string>("Exception")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Level")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Logger")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Message")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Thread")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.ToTable("T_Log");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.VacationWorkload", b =>
                {
                    b.Property<Guid>("VacationWorkloadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Friday")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool?>("Monday")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool?>("Thursday")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool?>("Tuesday")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("VacationPerYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(3, 0)")
                        .HasDefaultValueSql("((25))");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Wednesday")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("Workload")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(3, 0)")
                        .HasDefaultValueSql("((100))");

                    b.HasKey("VacationWorkloadId");

                    b.HasIndex(new[] { "EmployeeId", "ValidFrom" }, "UK_VacationWorkload")
                        .IsUnique();

                    b.ToTable("VacationWorkload");

                    b.HasData(
                        new
                        {
                            VacationWorkloadId = new Guid("49c645fa-a2c1-467f-b484-98b926d2383e"),
                            EmployeeId = new Guid("cd34ce4a-eacd-42ee-aeb7-4c17c0bfc6df"),
                            Friday = true,
                            Monday = true,
                            Thursday = true,
                            Tuesday = true,
                            VacationPerYear = 25.00m,
                            ValidFrom = new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Wednesday = true,
                            Workload = 100.00m
                        },
                        new
                        {
                            VacationWorkloadId = new Guid("129fb348-0f8a-45cd-98a4-0c50e75e46ec"),
                            EmployeeId = new Guid("8f102974-76d1-4af3-b6c3-1c2a0528fb9f"),
                            Friday = true,
                            Monday = true,
                            Thursday = true,
                            Tuesday = true,
                            VacationPerYear = 30.00m,
                            ValidFrom = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Wednesday = true,
                            Workload = 80.00m
                        },
                        new
                        {
                            VacationWorkloadId = new Guid("1dd7e460-cf2c-48a4-869f-7db92d12c02a"),
                            EmployeeId = new Guid("782802a7-5d9c-4c29-8df2-10775d3739b1"),
                            Friday = true,
                            Monday = true,
                            Thursday = true,
                            Tuesday = true,
                            VacationPerYear = 25.00m,
                            ValidFrom = new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Wednesday = true,
                            Workload = 100.00m
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.WorkingTime", b =>
                {
                    b.Property<Guid>("WorkingTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal>("DailyWorkingTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18, 2)")
                        .HasDefaultValueSql("((8))");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<decimal>("WorkingTime1")
                        .HasColumnType("numeric(18, 2)")
                        .HasColumnName("WorkingTime");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("WorkingTimeId");

                    b.HasIndex(new[] { "Year", "Month" }, "UK_WorkingTime")
                        .IsUnique();

                    b.ToTable("WorkingTime");

                    b.HasData(
                        new
                        {
                            WorkingTimeId = new Guid("8930a6ec-c9f3-44ad-ba23-7bc2f3128603"),
                            DailyWorkingTime = 8.00m,
                            Month = 3,
                            WorkingTime1 = 64.00m,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("TimeBooking.Data.Models.WorkloadReduction", b =>
                {
                    b.Property<Guid>("ReductionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Reduction")
                        .HasColumnType("numeric(3, 2)");

                    b.HasKey("ReductionId");

                    b.HasIndex(new[] { "Date" }, "UK_WorkloadReduction")
                        .IsUnique();

                    b.ToTable("WorkloadReduction");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Booking", b =>
                {
                    b.HasOne("TimeBooking.Data.Models.Employee", "Employee")
                        .WithMany("Bookings")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_Booking_Employee");

                    b.HasOne("TimeBooking.Data.Models.Process", "Process")
                        .WithMany("Bookings")
                        .HasForeignKey("ProcessId")
                        .IsRequired()
                        .HasConstraintName("FK_Booking_Process");

                    b.Navigation("Employee");

                    b.Navigation("Process");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Expense", b =>
                {
                    b.HasOne("TimeBooking.Data.Models.Employee", "Employee")
                        .WithMany("Expenses")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_Expense_Employee");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Process", b =>
                {
                    b.HasOne("TimeBooking.Data.Models.Project", "Project")
                        .WithMany("Processes")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK_Process_Project");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Project", b =>
                {
                    b.HasOne("TimeBooking.Data.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .IsRequired()
                        .HasConstraintName("FK_Project_Client");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.VacationWorkload", b =>
                {
                    b.HasOne("TimeBooking.Data.Models.Employee", "Employee")
                        .WithMany("VacationWorkloads")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_VacationWorkload_Employee");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Employee", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Expenses");

                    b.Navigation("VacationWorkloads");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Process", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("TimeBooking.Data.Models.Project", b =>
                {
                    b.Navigation("Processes");
                });
#pragma warning restore 612, 618
        }
    }
}
