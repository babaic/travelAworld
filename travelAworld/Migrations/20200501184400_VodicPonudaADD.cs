using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAworld.Migrations
{
    public partial class VodicPonudaADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ponuda_AspNetUsers_VodicId",
                table: "Ponuda");

            migrationBuilder.DropIndex(
                name: "IX_Ponuda_VodicId",
                table: "Ponuda");

            migrationBuilder.DropColumn(
                name: "VodicId",
                table: "Ponuda");

            migrationBuilder.CreateTable(
                name: "VodicPonuda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VodicId = table.Column<int>(nullable: false),
                    PonudaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VodicPonuda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VodicPonuda_Ponuda_PonudaId",
                        column: x => x.PonudaId,
                        principalTable: "Ponuda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VodicPonuda_AspNetUsers_VodicId",
                        column: x => x.VodicId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VodicPonuda_PonudaId",
                table: "VodicPonuda",
                column: "PonudaId");

            migrationBuilder.CreateIndex(
                name: "IX_VodicPonuda_VodicId",
                table: "VodicPonuda",
                column: "VodicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VodicPonuda");

            migrationBuilder.AddColumn<int>(
                name: "VodicId",
                table: "Ponuda",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ponuda_VodicId",
                table: "Ponuda",
                column: "VodicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ponuda_AspNetUsers_VodicId",
                table: "Ponuda",
                column: "VodicId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
