using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlayerAPI.Migrations
{
    public partial class addedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "Artist", "Genre", "Title" },
                values: new object[] { 1, "Taylor Swift", null, "Shake it Off" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "Artist", "Genre", "Title" },
                values: new object[] { 2, "The Lion King", null, "Hakuna Matata" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
