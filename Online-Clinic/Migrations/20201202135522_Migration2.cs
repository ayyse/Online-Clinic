using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Clinic.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ad",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "Ad",
                table: "Doktorlar");

            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "Hastalar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "Hastalar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoğumTarihi",
                table: "Hastalar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Hastalar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Şifre",
                table: "Hastalar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "Doktorlar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Doktorlar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Branş",
                table: "Doktorlar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "Doktorlar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoğumTarihi",
                table: "Doktorlar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Doktorlar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kurum",
                table: "Doktorlar",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Doktorlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Özgeçmiş",
                table: "Doktorlar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Şifre",
                table: "Doktorlar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Bağışçılar",
                columns: table => new
                {
                    BağışçıID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(nullable: false),
                    DoğumTarihi = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    Tür = table.Column<string>(nullable: true),
                    Kurum = table.Column<string>(nullable: true),
                    Özgeçmiş = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Şifre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bağışçılar", x => x.BağışçıID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bağışçılar");

            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "DoğumTarihi",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "Şifre",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Branş",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "DoğumTarihi",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Kurum",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Özgeçmiş",
                table: "Doktorlar");

            migrationBuilder.DropColumn(
                name: "Şifre",
                table: "Doktorlar");

            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "Hastalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "Doktorlar",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
