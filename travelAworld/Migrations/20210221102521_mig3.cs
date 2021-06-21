using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nekretnina_KategorijaNekretnina_KategorijaNekretninaId",
                table: "Nekretnina");

            migrationBuilder.DropColumn(
                name: "KategorijaNekretnineId",
                table: "Nekretnina");

            migrationBuilder.AlterColumn<int>(
                name: "KategorijaNekretninaId",
                table: "Nekretnina",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nekretnina_KategorijaNekretnina_KategorijaNekretninaId",
                table: "Nekretnina",
                column: "KategorijaNekretninaId",
                principalTable: "KategorijaNekretnina",
                principalColumn: "KategorijaNekretninaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nekretnina_KategorijaNekretnina_KategorijaNekretninaId",
                table: "Nekretnina");

            migrationBuilder.AlterColumn<int>(
                name: "KategorijaNekretninaId",
                table: "Nekretnina",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "KategorijaNekretnineId",
                table: "Nekretnina",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Nekretnina_KategorijaNekretnina_KategorijaNekretninaId",
                table: "Nekretnina",
                column: "KategorijaNekretninaId",
                principalTable: "KategorijaNekretnina",
                principalColumn: "KategorijaNekretninaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
