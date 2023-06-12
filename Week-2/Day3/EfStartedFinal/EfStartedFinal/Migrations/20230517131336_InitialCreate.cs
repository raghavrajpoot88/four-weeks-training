using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfStartedFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FProducts",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductFUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FProducts", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesFinal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FName = table.Column<string>(type: "TEXT", nullable: true),
                    FSerialNo = table.Column<string>(type: "TEXT", nullable: true),
                    ProductFinalIdProduct = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesFinal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriesFinal_FProducts_ProductFinalIdProduct",
                        column: x => x.ProductFinalIdProduct,
                        principalTable: "FProducts",
                        principalColumn: "IdProduct");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesFinal_ProductFinalIdProduct",
                table: "CategoriesFinal",
                column: "ProductFinalIdProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesFinal");

            migrationBuilder.DropTable(
                name: "FProducts");
        }
    }
}
