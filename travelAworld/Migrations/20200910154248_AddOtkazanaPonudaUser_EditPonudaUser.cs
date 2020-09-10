using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAworld.Migrations
{
    public partial class AddOtkazanaPonudaUser_EditPonudaUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "PonudaUser",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "OtkazanaPonudaUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PonudaUserId = table.Column<int>(nullable: false),
                    CijenaPonude = table.Column<double>(nullable: false),
                    IznosPovrata = table.Column<double>(nullable: false),
                    StatusDisputa = table.Column<int>(nullable: false),
                    DatumOtkazivanja = table.Column<DateTime>(nullable: false),
                    DatumZavrsetkaDisputa = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtkazanaPonudaUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtkazanaPonudaUser_PonudaUser_PonudaUserId",
                        column: x => x.PonudaUserId,
                        principalTable: "PonudaUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OtkazanaPonudaUser_PonudaUserId",
                table: "OtkazanaPonudaUser",
                column: "PonudaUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtkazanaPonudaUser");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "PonudaUser");
        }
    }
}
