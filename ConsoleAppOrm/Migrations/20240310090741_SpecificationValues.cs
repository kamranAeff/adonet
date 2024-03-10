using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppOrm.Migrations
{
    /// <inheritdoc />
    public partial class SpecificationValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecificationValues",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SpecificationId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationValues", x => new { x.ProductId, x.SpecificationId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecificationValues");
        }
    }
}
