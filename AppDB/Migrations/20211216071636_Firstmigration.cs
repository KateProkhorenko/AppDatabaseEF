using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDB.Migrations
{
    public partial class Firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    maker = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.model);
                });

            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    speed = table.Column<short>(type: "smallint", nullable: false),
                    ram = table.Column<short>(type: "smallint", nullable: false),
                    hd = table.Column<float>(type: "real", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: true),
                    screen = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.code);
                    table.ForeignKey(
                        name: "FK_Laptop_Product_model",
                        column: x => x.model,
                        principalTable: "Product",
                        principalColumn: "model",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PC",
                columns: table => new
                {
                    code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    speed = table.Column<short>(type: "smallint", nullable: false),
                    ram = table.Column<short>(type: "smallint", nullable: false),
                    hd = table.Column<float>(type: "real", nullable: false),
                    cd = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PC", x => x.code);
                    table.ForeignKey(
                        name: "FK_PC_Product_model",
                        column: x => x.model,
                        principalTable: "Product",
                        principalColumn: "model",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Printer",
                columns: table => new
                {
                    code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    color = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printer", x => x.code);
                    table.ForeignKey(
                        name: "FK_Printer_Product_model",
                        column: x => x.model,
                        principalTable: "Product",
                        principalColumn: "model",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_model",
                table: "Laptop",
                column: "model");

            migrationBuilder.CreateIndex(
                name: "IX_PC_model",
                table: "PC",
                column: "model");

            migrationBuilder.CreateIndex(
                name: "IX_Printer_model",
                table: "Printer",
                column: "model");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop");

            migrationBuilder.DropTable(
                name: "PC");

            migrationBuilder.DropTable(
                name: "Printer");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
