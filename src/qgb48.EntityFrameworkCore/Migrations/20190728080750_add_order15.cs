using Microsoft.EntityFrameworkCore.Migrations;

namespace qgb48.Migrations
{
    public partial class add_order15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Num",
                schema: "bloggingss",
                table: "OrderItem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Num",
                schema: "bloggingss",
                table: "OrderItem",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
