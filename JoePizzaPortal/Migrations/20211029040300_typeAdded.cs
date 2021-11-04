using Microsoft.EntityFrameworkCore.Migrations;

namespace JoePizzaPortal.Migrations
{
    public partial class typeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PizzaType",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaType",
                table: "Orders");
        }
    }
}
