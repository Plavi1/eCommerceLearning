using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class SeedComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1acd20a-dbb1-4d02-8603-dcc48684332f", "AQAAAAEAACcQAAAAEFDzfvl3TpBE1jLJdjDOxqlZdAMyEfuZilj6HssoVdBA1xr/nnfO8Fak90EWh3PT3A==", "c0893888-67bc-4b28-9c14-75a9fd1551ad" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 1,
                column: "imgRoute",
                value: "DilanDog.jpg");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 2,
                column: "imgRoute",
                value: "AlanFord.jpg");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 3,
                column: "imgRoute",
                value: "Blek.jpg");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 4,
                column: "imgRoute",
                value: "Zagor.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "092f7ab3-870e-460e-8945-d6bd1ada2df9", "AQAAAAEAACcQAAAAENddR7Dq0nLzUCHSy7KRdsf96qj3hWse7ugvJZCCge3bs6dx1VfQ11YlXktM4fJD6A==", "5054dea4-8272-4f9e-b241-c4c0273322f6" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 1,
                column: "imgRoute",
                value: "");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 2,
                column: "imgRoute",
                value: "");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 3,
                column: "imgRoute",
                value: "");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 4,
                column: "imgRoute",
                value: "");
        }
    }
}
