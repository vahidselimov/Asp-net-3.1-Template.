using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabutaj.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AddCart = table.Column<string>(nullable: true),
                    OldPrice = table.Column<decimal>(type: "decimal(3,0)", nullable: true),
                    NewPrice = table.Column<decimal>(type: "decimal(3,0)", nullable: true),
                    DiscountRate = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
