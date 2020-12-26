using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Clinic.Data.Migrations
{
    public partial class RandevuMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "Randevular",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bölüm",
                table: "Randevular",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoktorID",
                table: "Randevular",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Randevular",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HastaID",
                table: "Randevular",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mesaj",
                table: "Randevular",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Randevular",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_DoktorID",
                table: "Randevular",
                column: "DoktorID");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_HastaID",
                table: "Randevular",
                column: "HastaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_AspNetUsers_DoktorID",
                table: "Randevular",
                column: "DoktorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_AspNetUsers_HastaID",
                table: "Randevular",
                column: "HastaID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_AspNetUsers_DoktorID",
                table: "Randevular");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_AspNetUsers_HastaID",
                table: "Randevular");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_DoktorID",
                table: "Randevular");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_HastaID",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "Bölüm",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "DoktorID",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "HastaID",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "Mesaj",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Randevular");
        }
    }
}
