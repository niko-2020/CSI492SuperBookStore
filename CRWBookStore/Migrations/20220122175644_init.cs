using Microsoft.EntityFrameworkCore.Migrations;

namespace CRWBookStore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    BookName = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(nullable: false),
                    PriceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    PriceId = table.Column<int>(nullable: false),
                    PriceModelId = table.Column<int>(nullable: true),
                    BookModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryModel_BookModel_BookModelId",
                        column: x => x.BookModelId,
                        principalTable: "BookModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryModel_PriceModel_PriceModelId",
                        column: x => x.PriceModelId,
                        principalTable: "PriceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryModel_BookModelId",
                table: "InventoryModel",
                column: "BookModelId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryModel_PriceModelId",
                table: "InventoryModel",
                column: "PriceModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryModel");

            migrationBuilder.DropTable(
                name: "BookModel");

            migrationBuilder.DropTable(
                name: "PriceModel");
        }
    }
}
