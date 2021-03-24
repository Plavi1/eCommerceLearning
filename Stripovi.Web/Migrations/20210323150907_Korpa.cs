using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class Korpa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdStripa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korpa_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b93e0c34-6924-4eb8-a471-31f211ec6c42", "AQAAAAEAACcQAAAAEGKRpYt+7iQVtqbpeZ5DTvyfoZqg4kG77M96GbP67T9YdunlIIbgvxr+uVQsskY74Q==", "8adf8cee-ccd3-4cae-a6ab-5513b2a091be" });

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_UserId",
                table: "Korpa",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korpa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6955cb87-6c67-4f27-a582-60518e0d1537", "AQAAAAEAACcQAAAAEA2tcHLkaY+pxD4NIOa/bNBDNRkBYsQnQSh+EjfXIYagvPey3WSUCCeIY/KFMKsuRg==", "0b835d2a-61c4-402c-9636-99f925c179bb" });
        }
    }
}
