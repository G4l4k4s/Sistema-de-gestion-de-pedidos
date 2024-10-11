using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaGestionPedidos.Migrations
{
    /// <inheritdoc />
    public partial class SeedsAndTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categorys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorys", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_categorys_category_id",
                        column: x => x.category_id,
                        principalTable: "categorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "categorys",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Bebidas frías y calientes", "Bebidas" },
                    { 2, "Dulces y postres variados", "Postres" },
                    { 3, "Aperitivos y entradas ligeras", "Entradas" },
                    { 4, "Ensaladas frescas y saludables", "Ensaladas" },
                    { 5, "Variedad de pastas italianas", "Pastas" },
                    { 6, "Platos a base de carne", "Carnes" },
                    { 7, "Platos de mariscos frescos", "Pescados y Mariscos" },
                    { 8, "Opciones vegetarianas y veganas", "Vegetariano" },
                    { 9, "Hamburguesas, pizzas y más", "Comida Rápida" },
                    { 10, "Sopas y caldos variados", "Sopas" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_id", "description", "name", "price", "quantity" },
                values: new object[,]
                {
                    { 1, 1, "Café negro caliente", "Café", 2.50m, 100m },
                    { 2, 9, "Hamburguesa clásica con queso", "Hamburguesa", 8.99m, 50m },
                    { 3, 4, "Ensalada fresca con aderezo César", "Ensalada César", 6.50m, 30m },
                    { 4, 9, "Pizza tradicional italiana", "Pizza Margherita", 12.00m, 25m },
                    { 5, 2, "Tarta de manzana casera", "Tarta de Manzana", 4.00m, 40m },
                    { 6, 5, "Pasta con salsa Alfredo y pollo", "Pasta Alfredo", 9.75m, 20m },
                    { 7, 7, "Salmón fresco a la parrilla", "Filete de Salmón", 15.99m, 15m },
                    { 8, 10, "Sopa caliente de tomate", "Sopa de Tomate", 3.25m, 35m },
                    { 9, 8, "Sandwich de vegetales frescos", "Sandwich Vegetariano", 5.50m, 45m },
                    { 10, 1, "Jugo natural de naranja", "Jugo de Naranja", 2.00m, 60m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                table: "products",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categorys");
        }
    }
}
