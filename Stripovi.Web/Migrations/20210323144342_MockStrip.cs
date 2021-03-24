using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class MockStrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Strip",
                columns: table => new
                {
                    IdStripa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Izdavac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VremePosta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stanje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jezik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodinaIzdanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<int>(type: "int", nullable: false),
                    imgRoute = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strip", x => x.IdStripa);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6955cb87-6c67-4f27-a582-60518e0d1537", "AQAAAAEAACcQAAAAEA2tcHLkaY+pxD4NIOa/bNBDNRkBYsQnQSh+EjfXIYagvPey3WSUCCeIY/KFMKsuRg==", "0b835d2a-61c4-402c-9636-99f925c179bb" });

            migrationBuilder.InsertData(
                table: "Strip",
                columns: new[] { "IdStripa", "Autor", "Cena", "GodinaIzdanja", "Izdavac", "Jezik", "Naziv", "Stanje", "VremePosta", "imgRoute" },
                values: new object[,]
                {
                    { 1, "Ticijano Sklavi", 300, "2006", "Veseli Cetvrtak", "Srpski", "Dilan Dog", "Novo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 2, "Max Bunker ", 250, "1995", "Vsdada", "Srpski", "Alan Ford", "Novo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 3, "EsseGesse", 300, "1999", "Abcvasld", "Srpski", "Blek", "Polovno", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 4, "Serdjo Boneli", 100, "2012", "Veseli Cetvrtak", "Srpski", "Zagor", "Polovno", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Strip");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abde9efc-bd8d-472e-912f-23b9e730353e", "AQAAAAEAACcQAAAAEB75Ew9+FNf+FEY6QPAaJ0NXH/LFcT7KHahAp+4m9N4nq9/9Tk5/Ib5P3sEnehFEWA==", "31ca0652-196a-4a00-bdea-ec887a0c5b7c" });
        }
    }
}
