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
            migrationBuilder.DropTable(
                name: "Arbeitszeit");

            migrationBuilder.DropTable(
                name: "ArbeitszeitReduktion");

            migrationBuilder.DropTable(
                name: "Buchung");

            migrationBuilder.DropTable(
                name: "FerienArbeitspensum");

            migrationBuilder.DropTable(
                name: "MitarbeiterSaldo");

            migrationBuilder.DropTable(
                name: "Spesen");

            migrationBuilder.DropTable(
                name: "Vorgang");

            migrationBuilder.DropTable(
                name: "Mitarbeiter");

            migrationBuilder.DropTable(
                name: "Projekt");

            migrationBuilder.DropTable(
                name: "Kunde");

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
                        name: "FK_Projekt_Kunde",
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
                        name: "FK_Spesen_Mitarbeiter",
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
                        name: "FK_FerienArbeitspensum_Mitarbeiter",
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
                        name: "FK_Vorgang_Projekt",
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
                        name: "FK_Buchung_Mitarbeiter",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Buchung_Vorgang",
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

            migrationBuilder.CreateTable(
                name: "Arbeitszeit",
                columns: table => new
                {
                    ArbeitszeitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Arbeitszeit = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Jahr = table.Column<int>(type: "int", nullable: false),
                    Monat = table.Column<int>(type: "int", nullable: false),
                    Tagesarbeitszeit = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValueSql: "((8))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbeitszeit", x => x.ArbeitszeitId);
                });

            migrationBuilder.CreateTable(
                name: "ArbeitszeitReduktion",
                columns: table => new
                {
                    ReduktionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Reduktion = table.Column<decimal>(type: "numeric(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbeitszeitReduktion", x => x.ReduktionId);
                });

            migrationBuilder.CreateTable(
                name: "Kunde",
                columns: table => new
                {
                    KundeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adresse = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Intern = table.Column<bool>(type: "bit", nullable: false),
                    KundeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.KundeId);
                });

            migrationBuilder.CreateTable(
                name: "Mitarbeiter",
                columns: table => new
                {
                    MitarbeiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Austritt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Eintritt = table.Column<DateTime>(type: "datetime", nullable: false),
                    MitarbeiterName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MitarbeiterVorname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mitarbeiter", x => x.MitarbeiterId);
                });

            migrationBuilder.CreateTable(
                name: "MitarbeiterSaldo",
                columns: table => new
                {
                    MitarbeiterSaldoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    FerienSaldo = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Ist = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Jahr = table.Column<int>(type: "int", nullable: false),
                    MitarbeiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Monat = table.Column<int>(type: "int", nullable: false),
                    Soll = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    StundenSaldo = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MitarbeiterSaldo", x => x.MitarbeiterSaldoId);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    ProjektId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KundeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Gesamtkosten = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Mehrwertsteuer = table.Column<bool>(type: "bit", nullable: false),
                    Pauschal = table.Column<bool>(type: "bit", nullable: false),
                    ProjektBezeichnung = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ProjektNummer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Vertragsdauer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.ProjektId);
                    table.ForeignKey(
                        name: "FK_Projekt_Kunde",
                        column: x => x.KundeId,
                        principalTable: "Kunde",
                        principalColumn: "KundeId");
                });

            migrationBuilder.CreateTable(
                name: "FerienArbeitspensum",
                columns: table => new
                {
                    FerienArbeitspensumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MitarbeiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Arbeitspensum = table.Column<decimal>(type: "numeric(3,0)", nullable: false, defaultValueSql: "((100))"),
                    Dienstag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Donnerstag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    FerienProJahr = table.Column<decimal>(type: "numeric(3,0)", nullable: false, defaultValueSql: "((25))"),
                    Freitag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    GueltigAb = table.Column<DateTime>(type: "datetime", nullable: false),
                    Mittwoch = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Montag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FerienArbeitspensum", x => x.FerienArbeitspensumId);
                    table.ForeignKey(
                        name: "FK_FerienArbeitspensum_Mitarbeiter",
                        column: x => x.MitarbeiterId,
                        principalTable: "Mitarbeiter",
                        principalColumn: "MitarbeiterId");
                });

            migrationBuilder.CreateTable(
                name: "Spesen",
                columns: table => new
                {
                    SpesenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MitarbeiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnlassOrt = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Betrag = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Kreditkarte = table.Column<bool>(type: "bit", nullable: false),
                    Spesenart = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spesen", x => x.SpesenId);
                    table.ForeignKey(
                        name: "FK_Spesen_Mitarbeiter",
                        column: x => x.MitarbeiterId,
                        principalTable: "Mitarbeiter",
                        principalColumn: "MitarbeiterId");
                });

            migrationBuilder.CreateTable(
                name: "Vorgang",
                columns: table => new
                {
                    VorgangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjektId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    AnzahlStunden = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Ferien = table.Column<bool>(type: "bit", nullable: false),
                    Stundenansatz = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    VorgangBezeichnung = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vorgang", x => x.VorgangId);
                    table.ForeignKey(
                        name: "FK_Vorgang_Projekt",
                        column: x => x.ProjektId,
                        principalTable: "Projekt",
                        principalColumn: "ProjektId");
                });

            migrationBuilder.CreateTable(
                name: "Buchung",
                columns: table => new
                {
                    BuchungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MitarbeiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VorgangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuchungDatum = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuchungText = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BuchungZeitBis = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuchungZeitVon = table.Column<DateTime>(type: "datetime", nullable: false),
                    Stunden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buchung", x => x.BuchungId);
                    table.ForeignKey(
                        name: "FK_Buchung_Mitarbeiter",
                        column: x => x.MitarbeiterId,
                        principalTable: "Mitarbeiter",
                        principalColumn: "MitarbeiterId");
                    table.ForeignKey(
                        name: "FK_Buchung_Vorgang",
                        column: x => x.VorgangId,
                        principalTable: "Vorgang",
                        principalColumn: "VorgangId");
                });

            migrationBuilder.CreateIndex(
                name: "UK_Arbeitszeit",
                table: "Arbeitszeit",
                columns: new[] { "Jahr", "Monat" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ArbeitszeitReduktion",
                table: "ArbeitszeitReduktion",
                column: "Datum",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buchung_MitarbeiterId",
                table: "Buchung",
                column: "MitarbeiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Buchung_VorgangId",
                table: "Buchung",
                column: "VorgangId");

            migrationBuilder.CreateIndex(
                name: "UK_FerienArbeitspensum",
                table: "FerienArbeitspensum",
                columns: new[] { "MitarbeiterId", "GueltigAb" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_MitarbeiterSaldo",
                table: "MitarbeiterSaldo",
                columns: new[] { "MitarbeiterId", "Jahr", "Monat" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projekt_KundeId",
                table: "Projekt",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spesen_MitarbeiterId",
                table: "Spesen",
                column: "MitarbeiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Vorgang_ProjektId",
                table: "Vorgang",
                column: "ProjektId");
        }
    }
}
