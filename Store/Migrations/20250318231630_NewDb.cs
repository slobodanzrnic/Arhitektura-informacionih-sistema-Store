using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class NewDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price2 = table.Column<double>(type: "float", nullable: false),
                    Price3 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Jackets" },
                    { 2, 2, "T-shirts" },
                    { 3, 3, "Sweaters" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Manufacturer", "Name", "Price", "Price2", "Price3" },
                values: new object[,]
                {
                    { 1, "A cozy and comfortable sweatshirt made from soft fleece, perfect for everyday wear or post-workout relaxation", "Nike", "Club Fleece Sweatshirt", 100.0, 85.0, 70.0 },
                    { 2, "A lightweight, breathable pullover designed for maximum comfort, keeping you cool and stylish throughout the day.", "Nike", "Air Pullover", 110.0, 100.0, 90.0 },
                    { 3, "An essential piece for any active lifestyle, this sportswear is designed for optimal performance and everyday comfort.", "Nike", "Sportswear Essential", 80.0, 75.0, 70.0 },
                    { 4, "A sleek and modern design with a bold flame pattern, adding a touch of edge to your casual look.", "Hugo Boss", "Danda Flame", 70.0, 65.0, 60.0 },
                    { 5, "A stylish and versatile piece with sharp, clean lines for a sophisticated yet casual appearance.", "Hugo Boss", "Dikobra", 90.0, 85.0, 80.0 },
                    { 6, "Timeless and classic, this regular-fit piece offers a comfortable fit for all-day wear.", "Hugo Boss", "Regular Fit", 100.0, 95.0, 85.0 },
                    { 7, "Designed for those who prefer a traditional yet tailored look, this piece combines comfort with a perfect fit.", "Adidas", "Original fit", 150.0, 135.0, 115.0 },
                    { 8, "Engineered for performance and style, this piece is perfect for runners or anyone who values movement and comfort.", "Adidas", "Run It", 180.0, 160.0, 135.0 },
                    { 9, "Classic black and white design with durable construction, ideal for skaters or anyone who appreciates a street-style look.", "Adidas", "Skate Black & White", 150.0, 140.0, 130.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
