using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class Kontakt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kontakt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Razlog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakt", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e32f95ce-e0a0-4089-ba52-51458d34b6b2", "AQAAAAEAACcQAAAAEM/XmfHx680Su65RNRAepiVDd0H7Km3lMDc+eCgA1cIF2iiU2ToWfPpQL6F5Ie9yQw==", "59d17e04-fb53-4ab6-8a0d-ec605920f776" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kontakt");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23d0f37-7eda-487f-845e-5c8832ddaef9", "AQAAAAEAACcQAAAAEFdBWBwAWDgzmDUgG40IcW2uvuCV8CfxGh9b3/VFa5+N6DbQcDGTt8B5w0HK/n2EBA==", "597fcf8d-5b24-4428-8332-b30cf8c5c174" });
        }
    }
}
