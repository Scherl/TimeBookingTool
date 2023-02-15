using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeBooking.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbeitszeit",
                columns: table => new
                {
                    ArbeitszeitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Jahr = table.Column<int>(type: "int", nullable: false),
                    Monat = table.Column<int>(type: "int", nullable: false),
                    Arbeitszeit = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
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
                    KundeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Intern = table.Column<bool>(type: "bit", nullable: false),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Adresse = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
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
                    MitarbeiterName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MitarbeiterVorname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Eintritt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Austritt = table.Column<DateTime>(type: "datetime", nullable: false)
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
                    MitarbeiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jahr = table.Column<int>(type: "int", nullable: false),
                    Monat = table.Column<int>(type: "int", nullable: false),
                    StundenSaldo = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    FerienSaldo = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Soll = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Ist = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MitarbeiterSaldo", x => x.MitarbeiterSaldoId);
                });

            migrationBuilder.CreateTable(
                name: "T_Log",
                columns: table => new
                {
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    Thread = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Logger = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Benutzer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Computer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    ProjektId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KundeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjektNummer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ProjektBezeichnung = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Gesamtkosten = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Pauschal = table.Column<bool>(type: "bit", nullable: false),
                    Vertragsdauer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mehrwertsteuer = table.Column<bool>(type: "bit", nullable: false)
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
                    FerienProJahr = table.Column<decimal>(type: "numeric(3,0)", nullable: false, defaultValueSql: "((25))"),
                    Arbeitspensum = table.Column<decimal>(type: "numeric(3,0)", nullable: false, defaultValueSql: "((100))"),
                    GueltigAb = table.Column<DateTime>(type: "datetime", nullable: false),
                    Montag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Dienstag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Mittwoch = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Donnerstag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Freitag = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
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
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Betrag = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    AnlassOrt = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Spesenart = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Kreditkarte = table.Column<bool>(type: "bit", nullable: false)
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
                    VorgangBezeichnung = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Ferien = table.Column<bool>(type: "bit", nullable: false),
                    Stundenansatz = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    AnzahlStunden = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
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
                    VorgangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MitarbeiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuchungDatum = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuchungZeitVon = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuchungZeitBis = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuchungText = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "T_Log");

            migrationBuilder.DropTable(
                name: "Vorgang");

            migrationBuilder.DropTable(
                name: "Mitarbeiter");

            migrationBuilder.DropTable(
                name: "Projekt");

            migrationBuilder.DropTable(
                name: "Kunde");
        }
    }
}
