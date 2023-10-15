using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig_order_props : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderUsd",
                table: "Orders",
                newName: "SellUsd");

            migrationBuilder.RenameColumn(
                name: "OrderTRY",
                table: "Orders",
                newName: "SellForCountry");

            migrationBuilder.RenameColumn(
                name: "OrderProfitUsd",
                table: "Orders",
                newName: "BuyUsd");

            migrationBuilder.RenameColumn(
                name: "OrderProfitTry",
                table: "Orders",
                newName: "BuyTry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SellUsd",
                table: "Orders",
                newName: "OrderUsd");

            migrationBuilder.RenameColumn(
                name: "SellForCountry",
                table: "Orders",
                newName: "OrderTRY");

            migrationBuilder.RenameColumn(
                name: "BuyUsd",
                table: "Orders",
                newName: "OrderProfitUsd");

            migrationBuilder.RenameColumn(
                name: "BuyTry",
                table: "Orders",
                newName: "OrderProfitTry");
        }
    }
}
