using Microsoft.EntityFrameworkCore.Migrations;

namespace qgb48.Migrations
{
    public partial class add_order12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                nullable: true);
        }
    }
}
