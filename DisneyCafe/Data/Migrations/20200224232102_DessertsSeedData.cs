using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyCafe.Data.Migrations
{
    public partial class DessertsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "Id", "Description", "Price", "Stock", "Title" },
                values: new object[,]
                {
                    { 1, "Pie made with a lemon custard filling, using a shortcrust pastry, with a fluffy meringue topping", 7.4500000000000002, 0, "Lemon Meringue Pie" },
                    { 2, "graham cracker crust with a mixture of soft cheese, eggs, and sugar", 6.25, 0, "Cheesecake" },
                    { 3, "Ube made into a swiss roll filled with butter, sugar, milk, and mashed ube", 9.6500000000000004, 0, "Ube Roll" },
                    { 4, "Cake pop made with a devil chocolate cake recipe", 3.6000000000000001, 0, "Chocolate Cake Pop" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
