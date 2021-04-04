using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class Naslov : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Autor",
                table: "Strip",
                newName: "Naslov");

            migrationBuilder.RenameColumn(
                name: "Autor",
                table: "Korpa",
                newName: "Naslov");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23d0f37-7eda-487f-845e-5c8832ddaef9", "AQAAAAEAACcQAAAAEFdBWBwAWDgzmDUgG40IcW2uvuCV8CfxGh9b3/VFa5+N6DbQcDGTt8B5w0HK/n2EBA==", "597fcf8d-5b24-4428-8332-b30cf8c5c174" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 1,
                column: "Naslov",
                value: "Prica o Dilanu Dogu");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 2,
                column: "Naslov",
                value: "Tako je nastala grupa");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 3,
                column: "Naslov",
                value: "Pobuna Trapera");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 4,
                column: "Naslov",
                value: "Gospodari");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Naslov",
                table: "Strip",
                newName: "Autor");

            migrationBuilder.RenameColumn(
                name: "Naslov",
                table: "Korpa",
                newName: "Autor");

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
                column: "Autor",
                value: "Ticijano Sklavi");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 2,
                column: "Autor",
                value: "Max Bunker ");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 3,
                column: "Autor",
                value: "EsseGesse");

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 4,
                column: "Autor",
                value: "Serdjo Boneli");
        }
    }
}
