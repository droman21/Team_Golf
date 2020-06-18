using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Golf.Migrations
{
    public partial class AddedCourseTypeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseType",
                table: "GolfCourses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseType",
                value: "18Hole");

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseType",
                value: "PuttPutt");

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseType",
                value: "9Hole");

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseType",
                value: "Par3");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewText",
                value: "I played good. This course is awesome.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewText",
                value: "I'm a pro, and wouldn't play a crappy course like this.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ReviewText", "ReviewerName" },
                values: new object[] { "I forgot my clubs and didn't actually play.", "Tom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseType",
                table: "GolfCourses");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewText",
                value: "I played bad. This course sucks.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewText",
                value: "I played bad. This course sucks.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ReviewText", "ReviewerName" },
                values: new object[] { "I played bad. This course sucks.", "Dan" });
        }
    }
}
