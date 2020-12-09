using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Clinic.Data.Migrations
{
    public partial class HastaMigrt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hasta_AdSoyad",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "HastaID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Ad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor_Soyad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hasta_Ad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hasta_Soyad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HastaBağışTalebi_DoktorID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Onay",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TalepAçıklaması",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TalepTarihi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doktor",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Randevu_HastaID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RandevuID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Saat",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers",
                column: "HastaBağışTalebi_DoktorID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HastaID",
                table: "AspNetUsers",
                column: "HastaID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Randevu_HastaID",
                table: "AspNetUsers",
                column: "Randevu_HastaID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers",
                column: "HastaBağışTalebi_DoktorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_HastaID",
                table: "AspNetUsers",
                column: "HastaID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Randevu_HastaID",
                table: "AspNetUsers",
                column: "Randevu_HastaID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_HastaID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Randevu_HastaID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HastaID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Randevu_HastaID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Ad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor_Soyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hasta_Ad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hasta_Soyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HastaBağışTalebi_DoktorID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Onay",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TalepAçıklaması",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TalepTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Doktor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Randevu_HastaID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RandevuID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Saat",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "HastaID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hasta_AdSoyad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
