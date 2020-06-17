using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Golf.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GolfCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfCourses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GolfCourses",
                columns: new[] { "Id", "Image", "Name", "Review" },
                values: new object[] { 1, "Bushwood.jpg", "Bushwood CC", "Good snack shack and poor caddying" });

            migrationBuilder.InsertData(
                table: "GolfCourses",
                columns: new[] { "Id", "Image", "Name", "Review" },
                values: new object[] { 2, "FurryCreek.jpg", "Fury Creek Golf CC", "Price is wrong B&$#%" });

            migrationBuilder.InsertData(
                table: "GolfCourses",
                columns: new[] { "Id", "Image", "Name", "Review" },
                values: new object[] { 3, "Cottonwood.jpg", "Cotton Wood", "Waggle and let the big dog eat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GolfCourses");
        }
    }
}
