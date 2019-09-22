using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Infra.Data.Migrations
{
    public partial class AddSummaryToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Movie",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Movie");
        }
    }
}
