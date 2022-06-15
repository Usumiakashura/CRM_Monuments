using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class migr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedallionSizeId",
                table: "PhotoOnMonuments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MedallionMaterialShapeMedallion",
                columns: table => new
                {
                    MedallionMaterialsId = table.Column<int>(type: "int", nullable: false),
                    ShapesMedallionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedallionMaterialShapeMedallion", x => new { x.MedallionMaterialsId, x.ShapesMedallionId });
                    table.ForeignKey(
                        name: "FK_MedallionMaterialShapeMedallion_MedallionMaterials_MedallionMaterialsId",
                        column: x => x.MedallionMaterialsId,
                        principalTable: "MedallionMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedallionMaterialShapeMedallion_ShapeMedallions_ShapesMedallionId",
                        column: x => x.ShapesMedallionId,
                        principalTable: "ShapeMedallions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedallionSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedallionSize", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_MedallionSizeId",
                table: "PhotoOnMonuments",
                column: "MedallionSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedallionMaterialShapeMedallion_ShapesMedallionId",
                table: "MedallionMaterialShapeMedallion",
                column: "ShapesMedallionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_MedallionSize_MedallionSizeId",
                table: "PhotoOnMonuments",
                column: "MedallionSizeId",
                principalTable: "MedallionSize",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_MedallionSize_MedallionSizeId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropTable(
                name: "MedallionMaterialShapeMedallion");

            migrationBuilder.DropTable(
                name: "MedallionSize");

            migrationBuilder.DropIndex(
                name: "IX_PhotoOnMonuments_MedallionSizeId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "MedallionSizeId",
                table: "PhotoOnMonuments");
        }
    }
}
