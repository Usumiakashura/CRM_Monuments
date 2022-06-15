using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class migr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_MedallionSize_MedallionSizeId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedallionSize",
                table: "MedallionSize");

            migrationBuilder.RenameTable(
                name: "MedallionSize",
                newName: "MedallionSizes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedallionSizes",
                table: "MedallionSizes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MedallionPrices",
                columns: table => new
                {
                    MedallionSizeId = table.Column<int>(type: "int", nullable: false),
                    MedallionMaterialId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedallionPrices", x => new { x.MedallionMaterialId, x.MedallionSizeId });
                    table.ForeignKey(
                        name: "FK_MedallionPrices_MedallionMaterials_MedallionMaterialId",
                        column: x => x.MedallionMaterialId,
                        principalTable: "MedallionMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedallionPrices_MedallionSizes_MedallionSizeId",
                        column: x => x.MedallionSizeId,
                        principalTable: "MedallionSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedallionPrices_MedallionSizeId",
                table: "MedallionPrices",
                column: "MedallionSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_MedallionSizes_MedallionSizeId",
                table: "PhotoOnMonuments",
                column: "MedallionSizeId",
                principalTable: "MedallionSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_MedallionSizes_MedallionSizeId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropTable(
                name: "MedallionPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedallionSizes",
                table: "MedallionSizes");

            migrationBuilder.RenameTable(
                name: "MedallionSizes",
                newName: "MedallionSize");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedallionSize",
                table: "MedallionSize",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_MedallionSize_MedallionSizeId",
                table: "PhotoOnMonuments",
                column: "MedallionSizeId",
                principalTable: "MedallionSize",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
