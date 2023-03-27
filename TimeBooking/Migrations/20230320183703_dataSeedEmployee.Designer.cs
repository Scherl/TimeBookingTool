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
    [Migration("20230320183703_dataSeedEmployee")]
    partial class dataSeedEmployee
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
                            ClientId = new Guid("93703d24-2108-4eb8-855a-47ea7bd34a9a"),
                            Address = "TestStrasse 1, 3303 Jegenstorf",
                            ClientName = "TestClient 1",
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

                    b.Property<DateTime>("Exit")
                        .HasColumnType("datetime");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = new Guid("476d1037-e2c9-4e4a-aeee-307a6f25742c"),
                            EmployeeFirstName = "FirstNameTest",
                            EmployeeLastName = "LastNameTest",
                            Entry = new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Exit = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999)
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
