using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyCafe.Data.Migrations
{
    public partial class AddingIngredientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Mesurement = table.Column<string>(maxLength: 25, nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    LastOrdered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
