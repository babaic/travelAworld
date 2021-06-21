using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class editRezervacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumPrijave",
                table: "Rezervacija",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "VrijemeOdjave",
                table: "Rezervacija",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VrijemePrijave",
                table: "Rezervacija",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumPrijave",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "VrijemeOdjave",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "VrijemePrijave",
                table: "Rezervacija");
        }
    }
}
