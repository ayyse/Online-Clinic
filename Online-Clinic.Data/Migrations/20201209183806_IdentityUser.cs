using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Clinic.Data.Migrations
{
    public partial class IdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BağışçıID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoğumTarihi",
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
                name: "Şifre",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ad",
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
                name: "Doktor_Cinsiyet",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoktorID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Doktor_DoğumTarihi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Kurum",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Özgeçmiş",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Şifre",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hasta_AdSoyad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hasta_Cinsiyet",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Hasta_DoğumTarihi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HastaID",
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

            migrationBuilder.AddColumn<string>(
                name: "Hasta_Şifre",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BağışçıID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoğumTarihi",
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
                name: "Şifre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Adres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Branş",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Cinsiyet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoktorID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_DoğumTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Kurum",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Özgeçmiş",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Şifre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hasta_AdSoyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hasta_Cinsiyet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hasta_DoğumTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HastaID",
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

            migrationBuilder.DropColumn(
                name: "Hasta_Şifre",
                table: "AspNetUsers");
        }
    }
}
