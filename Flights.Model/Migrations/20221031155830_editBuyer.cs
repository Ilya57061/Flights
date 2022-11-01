using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flights.Model.Migrations
{
    public partial class editBuyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Buyers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
