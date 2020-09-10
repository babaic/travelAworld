using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAworld.Migrations
{
    public partial class EditOtkazanaPonudaUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumZavrsetkaDisputa",
                table: "OtkazanaPonudaUser",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumZavrsetkaDisputa",
                table: "OtkazanaPonudaUser",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
