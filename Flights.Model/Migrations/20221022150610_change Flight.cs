using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flights.Model.Migrations
{
    public partial class changeFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "First",
                table: "Flights");

            migrationBuilder.AddColumn<int>(
                name: "CountSeats",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountSeats",
                table: "Flights");

            migrationBuilder.AddColumn<decimal>(
                name: "First",
                table: "Flights",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
