using Microsoft.EntityFrameworkCore.Migrations;

namespace CapaAccesoDatos.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carrito",
                columns: table => new
                {
                    CarritoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorID = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrito", x => x.CarritoID);
                });

            migrationBuilder.CreateTable(
                name: "CarritoProducto",
                columns: table => new
                {
                    ProductoCarritoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarritoID = table.Column<int>(type: "int", nullable: false),
                    ProductoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoProducto", x => x.ProductoCarritoID);
                    table.ForeignKey(
                        name: "FK_CarritoProducto_carrito_CarritoID",
                        column: x => x.CarritoID,
                        principalTable: "carrito",
                        principalColumn: "CarritoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarritoProducto_CarritoID",
                table: "CarritoProducto",
                column: "CarritoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarritoProducto");

            migrationBuilder.DropTable(
                name: "carrito");
        }
    }
}
