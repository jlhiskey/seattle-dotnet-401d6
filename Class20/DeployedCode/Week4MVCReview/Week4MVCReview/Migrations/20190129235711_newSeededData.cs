using Microsoft.EntityFrameworkCore.Migrations;

namespace Week4MVCReview.Migrations
{
    public partial class newSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Basket Weaving", 100 },
                    { 2, "RacketBall", 50 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 50, "Barbie", "Doll" },
                    { 2, 80, "Donald", "Duck" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
