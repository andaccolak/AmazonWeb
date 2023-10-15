using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migccno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreditCardName",
                table: "CreditCards",
                newName: "CreditCardOwner");

            migrationBuilder.AddColumn<int>(
                name: "CreditCardNumber",
                table: "CreditCards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditCardNumber",
                table: "CreditCards");

            migrationBuilder.RenameColumn(
                name: "CreditCardOwner",
                table: "CreditCards",
                newName: "CreditCardName");
        }
    }
}
