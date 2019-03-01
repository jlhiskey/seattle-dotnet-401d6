using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPostCMS.Migrations
{
    public partial class newSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Cats are the best!", "Cats Rule" },
                    { 2, "It's true, the internet said so", "Coffee drinkers live longer lives" },
                    { 3, "We all have fun learning. Make our brains exercise!!", "Learning is Fun!" },
                    { 4, "Disney Addiction is a real thing. We all love Mickey! He is the happiest mouse on earth!", "Disney Addictions" },
                    { 5, "Cohort 6 is the best cohort of 2019!", "Code Fellows .NET Cohort 6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
