using Microsoft.EntityFrameworkCore.Migrations;

namespace EFStudentEnrollment.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Name", "Price", "Technology" },
                values: new object[,]
                {
                    { 1, ".NET", 100.00m, 0 },
                    { 2, "Python", 100.00m, 3 },
                    { 3, "Android Development", 150m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 35, "Jack", "Shepard" },
                    { 2, 30, "Kate", "Austin" },
                    { 3, 20, "Hermione", "Granger" }
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
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
