using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerTeamTracker.Migrations
{
    public partial class SeedTeamDataUpdatedPlayerAndTeamTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Teams",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JerseySize",
                table: "Players",
                type: "integer",
                nullable: false,
                defaultValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Players",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { 1, "Brown", "Bears" },
                    { 2, "Green", "Alligators" },
                    { 3, "Yellow", "Cheetahs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "JerseySize",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Players");
        }
    }
}
