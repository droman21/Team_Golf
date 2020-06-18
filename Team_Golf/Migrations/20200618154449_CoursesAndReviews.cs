using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Golf.Migrations
{
    public partial class CoursesAndReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "GolfCourses");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GolfCourses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(nullable: true),
                    ReviewText = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<string>(nullable: true),
                    ReviewRating = table.Column<int>(nullable: false),
                    GolfCourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_GolfCourses_GolfCourseId",
                        column: x => x.GolfCourseId,
                        principalTable: "GolfCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Good snack shack and poor caddying");

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Price is wrong B&$#%");

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Waggle and let the big dog eat");

            migrationBuilder.InsertData(
                table: "GolfCourses",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[] { 4, "Great course for beginners, not so much for the advanced player", "golfcouse5.jpg", "Little Met" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "GolfCourseId", "ReviewDate", "ReviewRating", "ReviewText", "ReviewerName" },
                values: new object[,]
                {
                    { 1, 1, "06-18-2020", 1, "I played bad. This course sucks.", "Ron" },
                    { 2, 1, "06-18-2020", 2, "I played bad. This course sucks.", "Dan" },
                    { 3, 2, "06-18-2020", 3, "I played bad. This course sucks.", "Chuck" },
                    { 4, 1, "06-18-2020", 4, "I played bad. This course sucks.", "Dan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GolfCourseId",
                table: "Reviews",
                column: "GolfCourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DeleteData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "GolfCourses");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "GolfCourses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Review",
                value: "Good snack shack and poor caddying");

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Review",
                value: "Price is wrong B&$#%");

            migrationBuilder.UpdateData(
                table: "GolfCourses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Review",
                value: "Waggle and let the big dog eat");
        }
    }
}
