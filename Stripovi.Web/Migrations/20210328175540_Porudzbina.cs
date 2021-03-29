using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class Porudzbina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_AspNetUsers_UserId",
                table: "Korpa");

            migrationBuilder.CreateTable(
                name: "Porudzbina",
                columns: table => new
                {
                    IdPorudzbine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostanskiBroj = table.Column<int>(type: "int", nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KucniBroj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placanje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pitanje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UkupnaCena = table.Column<int>(type: "int", nullable: false),
                    BrojPorucenihStripova = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porudzbina", x => x.IdPorudzbine);
                    table.ForeignKey(
                        name: "FK_Porudzbina_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StripInPorudzbina",
                columns: table => new
                {
                    IdPorudzbine = table.Column<int>(type: "int", nullable: false),
                    IdStripa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripInPorudzbina", x => new { x.IdPorudzbine, x.IdStripa });
                    table.ForeignKey(
                        name: "FK_StripInPorudzbina_Porudzbina_IdPorudzbine",
                        column: x => x.IdPorudzbine,
                        principalTable: "Porudzbina",
                        principalColumn: "IdPorudzbine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StripInPorudzbina_Strip_IdStripa",
                        column: x => x.IdStripa,
                        principalTable: "Strip",
                        principalColumn: "IdStripa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4783d741-6bfa-48bb-b166-4b4a2ae17487", "AQAAAAEAACcQAAAAEInWRSPncS6SSfck0DZidtmOKzGlblIqa35o/COtvcDm6G8bimo5ZdWXAJGg8Ux/PA==", "e0e25e7b-3031-4ad7-8ca2-85687d18575a" });

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbina_UserId",
                table: "Porudzbina",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StripInPorudzbina_IdStripa",
                table: "StripInPorudzbina",
                column: "IdStripa");

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_AspNetUsers_UserId",
                table: "Korpa",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_AspNetUsers_UserId",
                table: "Korpa");

            migrationBuilder.DropTable(
                name: "StripInPorudzbina");

            migrationBuilder.DropTable(
                name: "Porudzbina");

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
    }
}
