using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Clinic.Migrations
{
    public partial class Hasta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Doktorlar");

            migrationBuilder.AddColumn<string>(
                name: "HastalıkGeçmişi",
                table: "Hastalar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KronikHastalıklar",
                table: "Hastalar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TedaviEdenDoktor",
                table: "Hastalar",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HastalıkGeçmişi",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "KronikHastalıklar",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "TedaviEdenDoktor",
                table: "Hastalar");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Doktorlar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
