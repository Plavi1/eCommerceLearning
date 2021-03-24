using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class KorpaUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_AspNetUsers_UserId",
                table: "Korpa");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Korpa",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cena",
                table: "Korpa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GodinaIzdanja",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Izdavac",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Jezik",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stanje",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VremePosta",
                table: "Korpa",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "imgRoute",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e53e6823-a367-4ba8-9e98-41b7e148f802", "AQAAAAEAACcQAAAAEExEIfVM/MU5uRcNO7cnzScvlnBPmWvHKKIjGv/hbHpB3EV/B1j7aU/t8SMiT5ODlQ==", "4336a380-c0b4-4465-a7bc-4f22976de446" });

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_AspNetUsers_UserId",
                table: "Korpa",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_AspNetUsers_UserId",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "GodinaIzdanja",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "Izdavac",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "Jezik",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "Stanje",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "VremePosta",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "imgRoute",
                table: "Korpa");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Korpa",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b93e0c34-6924-4eb8-a471-31f211ec6c42", "AQAAAAEAACcQAAAAEGKRpYt+7iQVtqbpeZ5DTvyfoZqg4kG77M96GbP67T9YdunlIIbgvxr+uVQsskY74Q==", "8adf8cee-ccd3-4cae-a6ab-5513b2a091be" });

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_AspNetUsers_UserId",
                table: "Korpa",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
