using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoviePrice",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Movies");

            migrationBuilder.AddColumn<double>(
                name: "MoviePrice",
                table: "Tickets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
