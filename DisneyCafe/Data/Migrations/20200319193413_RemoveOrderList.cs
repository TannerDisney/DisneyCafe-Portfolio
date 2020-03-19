using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyCafe.Data.Migrations
{
    public partial class RemoveOrderList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desserts_Orders_OrdersOrderId",
                table: "Desserts");

            migrationBuilder.DropIndex(
                name: "IX_Desserts_OrdersOrderId",
                table: "Desserts");

            migrationBuilder.DropColumn(
                name: "OrdersOrderId",
                table: "Desserts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderId",
                table: "Desserts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desserts_OrdersOrderId",
                table: "Desserts",
                column: "OrdersOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Desserts_Orders_OrdersOrderId",
                table: "Desserts",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
