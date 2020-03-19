using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyCafe.Data.Migrations
{
    public partial class ChangedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerInfomationId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerInfomationId",
                table: "Orders",
                column: "CustomerInfomationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CustomerInfomations_CustomerInfomationId",
                table: "Orders",
                column: "CustomerInfomationId",
                principalTable: "CustomerInfomations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CustomerInfomations_CustomerInfomationId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerInfomationId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerInfomationId",
                table: "Orders");
        }
    }
}
