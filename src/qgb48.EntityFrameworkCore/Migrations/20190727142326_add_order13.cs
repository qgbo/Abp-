using Microsoft.EntityFrameworkCore.Migrations;

namespace qgb48.Migrations
{
    public partial class add_order13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.EnsureSchema(
                name: "blogging");

            migrationBuilder.EnsureSchema(
                name: "bloggingss");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order",
                newSchema: "blogging");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem",
                newSchema: "bloggingss");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                schema: "bloggingss",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                schema: "blogging",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                schema: "bloggingss",
                table: "OrderItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                schema: "bloggingss",
                table: "OrderItem",
                column: "OrderId",
                principalSchema: "blogging",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                schema: "bloggingss",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                schema: "bloggingss",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                schema: "blogging",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                schema: "bloggingss",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Order",
                schema: "blogging",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
