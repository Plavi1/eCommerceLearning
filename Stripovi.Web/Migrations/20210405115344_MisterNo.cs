using Microsoft.EntityFrameworkCore.Migrations;

namespace Stripovi.Web.Migrations
{
    public partial class MisterNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e54d035-8c51-4f46-a0e8-2c9d776b6980", "AQAAAAEAACcQAAAAEPUgDAD9JYYNA+uUPgZo+ZzhnL3Xpy3PApLoN+89MsxPh4bUIlafyLqVXz9aIZfIPw==", "7008748d-991b-4836-8523-8af653083b42" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 1,
                columns: new[] { "Cena", "GodinaIzdanja", "Naslov", "Naziv", "imgRoute" },
                values: new object[] { 230, "2010", "Cena izdaje", "Mister NO", "MisterNO.jpg" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 2,
                columns: new[] { "Cena", "GodinaIzdanja", "Izdavac", "Naslov", "Naziv", "imgRoute" },
                values: new object[] { 300, "2006", "Veseli Cetvrtak", "Prica o Dilanu Dogu", "Dilan Dog", "DilanDog.jpg" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 3,
                columns: new[] { "Cena", "GodinaIzdanja", "Izdavac", "Naslov", "Naziv", "Stanje", "imgRoute" },
                values: new object[] { 250, "1995", "Classic", "Tako je nastala grupa", "Alan Ford", "Novo", "AlanFord.jpg" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 4,
                columns: new[] { "Cena", "GodinaIzdanja", "Izdavac", "Naslov", "Naziv", "imgRoute" },
                values: new object[] { 300, "2000", "Wizard", "Pobuna Trapera", "Blek", "Blek.jpg" });

            migrationBuilder.InsertData(
                table: "Strip",
                columns: new[] { "IdStripa", "Cena", "GodinaIzdanja", "Izdavac", "Jezik", "Naslov", "Naziv", "Stanje", "imgRoute" },
                values: new object[] { 5, 100, "2012", "Veseli Cetvrtak", "Srpski", "Gospodari", "Zagor", "Polovno", "Zagor.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e32f95ce-e0a0-4089-ba52-51458d34b6b2", "AQAAAAEAACcQAAAAEM/XmfHx680Su65RNRAepiVDd0H7Km3lMDc+eCgA1cIF2iiU2ToWfPpQL6F5Ie9yQw==", "59d17e04-fb53-4ab6-8a0d-ec605920f776" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 1,
                columns: new[] { "Cena", "GodinaIzdanja", "Naslov", "Naziv", "imgRoute" },
                values: new object[] { 300, "2006", "Prica o Dilanu Dogu", "Dilan Dog", "DilanDog.jpg" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 2,
                columns: new[] { "Cena", "GodinaIzdanja", "Izdavac", "Naslov", "Naziv", "imgRoute" },
                values: new object[] { 250, "1995", "Vsdada", "Tako je nastala grupa", "Alan Ford", "AlanFord.jpg" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 3,
                columns: new[] { "Cena", "GodinaIzdanja", "Izdavac", "Naslov", "Naziv", "Stanje", "imgRoute" },
                values: new object[] { 300, "1999", "Abcvasld", "Pobuna Trapera", "Blek", "Polovno", "Blek.jpg" });

            migrationBuilder.UpdateData(
                table: "Strip",
                keyColumn: "IdStripa",
                keyValue: 4,
                columns: new[] { "Cena", "GodinaIzdanja", "Izdavac", "Naslov", "Naziv", "imgRoute" },
                values: new object[] { 100, "2012", "Veseli Cetvrtak", "Gospodari", "Zagor", "Zagor.jpg" });
        }
    }
}
