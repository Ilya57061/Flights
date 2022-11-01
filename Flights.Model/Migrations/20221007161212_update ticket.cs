using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flights.Model.Migrations
{
    public partial class updateticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Buyers_BuyerId",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "BuyerId",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Buyers_BuyerId",
                table: "Tickets",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Buyers_BuyerId",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "BuyerId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Buyers_BuyerId",
                table: "Tickets",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
