using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class EditNekretninav2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nekretnina_Grad_GradId",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "LokacijaId",
                table: "Nekretnina");

            migrationBuilder.AlterColumn<int>(
                name: "GradId",
                table: "Nekretnina",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nekretnina_Grad_GradId",
                table: "Nekretnina",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "GradId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nekretnina_Grad_GradId",
                table: "Nekretnina");

            migrationBuilder.AlterColumn<int>(
                name: "GradId",
                table: "Nekretnina",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LokacijaId",
                table: "Nekretnina",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Nekretnina_Grad_GradId",
                table: "Nekretnina",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "GradId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
