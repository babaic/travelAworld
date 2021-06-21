using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class editPonudaType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Kvadratura",
                table: "Nekretnina",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Kvadratura",
                table: "Nekretnina",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
