using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMastery.Migrations
{
    public partial class TestSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "SeriesId", "Name" },
                values: new object[] { 1, "TestSeries" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "SeriesId" },
                values: new object[] { 1, "TestGame", 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Body", "GameId", "Title" },
                values: new object[] { 1, "TestBody", 1, "TestComment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 1);
        }
    }
}
