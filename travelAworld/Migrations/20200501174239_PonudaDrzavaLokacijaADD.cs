using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAworld.Migrations
{
    public partial class PonudaDrzavaLokacijaADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lokacija_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ponuda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naslov = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    DatumPolaska = table.Column<DateTime>(nullable: false),
                    DatumPovratka = table.Column<DateTime>(nullable: false),
                    Cijena = table.Column<float>(nullable: false),
                    CijenaUkljuceno = table.Column<string>(nullable: true),
                    CijenaIskljuceno = table.Column<string>(nullable: true),
                    Napomena = table.Column<string>(nullable: true),
                    Hotel = table.Column<string>(nullable: true),
                    LokacijaId = table.Column<int>(nullable: false),
                    VodicId = table.Column<int>(nullable: false),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponuda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ponuda_Lokacija_LokacijaId",
                        column: x => x.LokacijaId,
                        principalTable: "Lokacija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ponuda_AspNetUsers_VodicId",
                        column: x => x.VodicId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lokacija_DrzavaId",
                table: "Lokacija",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ponuda_LokacijaId",
                table: "Ponuda",
                column: "LokacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ponuda_VodicId",
                table: "Ponuda",
                column: "VodicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ponuda");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
