using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Clinic.Data.Migrations
{
    public partial class VisitorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HastaBağışTalepleri",
                table: "HastaBağışTalepleri");

            migrationBuilder.RenameTable(
                name: "HastaBağışTalepleri",
                newName: "BağışTalepleri");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kurum",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tür",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Özgeçmiş",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Adres",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Branş",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Kurum",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Özgeçmiş",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HastalıkGeçmişi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KronikHastalıklar",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TedaviEdenDoktor",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BağışTalepleri",
                table: "BağışTalepleri",
                column: "TalepID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BağışTalepleri",
                table: "BağışTalepleri");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Kurum",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tür",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Özgeçmiş",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Adres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Branş",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Kurum",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Özgeçmiş",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HastalıkGeçmişi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KronikHastalıklar",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TedaviEdenDoktor",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "BağışTalepleri",
                newName: "HastaBağışTalepleri");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HastaBağışTalepleri",
                table: "HastaBağışTalepleri",
                column: "TalepID");
        }
    }
}
