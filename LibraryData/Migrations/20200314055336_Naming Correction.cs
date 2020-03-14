using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class NamingCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_GetLibraryCardId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_GetLibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "GetLibraryCardId",
                table: "Patrons");

            migrationBuilder.AddColumn<int>(
                name: "LibraryCardId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibraryCardId",
                table: "Patrons");

            migrationBuilder.AddColumn<int>(
                name: "GetLibraryCardId",
                table: "Patrons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_GetLibraryCardId",
                table: "Patrons",
                column: "GetLibraryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_GetLibraryCardId",
                table: "Patrons",
                column: "GetLibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
