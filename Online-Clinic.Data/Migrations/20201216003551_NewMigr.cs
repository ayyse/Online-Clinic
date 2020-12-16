using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Clinic.Data.Migrations
{
    public partial class NewMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "HastaBağışTalebi_DoktorID",
                table: "AspNetUsers",
                newName: "DoktorID1");

            migrationBuilder.AlterColumn<string>(
                name: "DoktorID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoktorID1",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DoktorID",
                table: "AspNetUsers",
                column: "DoktorID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_DoktorID",
                table: "AspNetUsers",
                column: "DoktorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_DoktorID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DoktorID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DoktorID1",
                table: "AspNetUsers",
                newName: "HastaBağışTalebi_DoktorID");

            migrationBuilder.AlterColumn<int>(
                name: "DoktorID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HastaBağışTalebi_DoktorID",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers",
                column: "HastaBağışTalebi_DoktorID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_HastaBağışTalebi_DoktorID",
                table: "AspNetUsers",
                column: "HastaBağışTalebi_DoktorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
