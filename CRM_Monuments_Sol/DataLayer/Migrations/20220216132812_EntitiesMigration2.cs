using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class EntitiesMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_Contracts_ContractId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoOnMonuments_ContractId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "PhotoOnMonuments");

            migrationBuilder.AddColumn<bool>(
                name: "DeletedCheck",
                table: "PhotoOnMonuments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DeletedCheck",
                table: "Deceaseds",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DeletedCheck",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ColorMedallions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameColor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorMedallions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedallionMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedallionMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShapeMedallions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameShape = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShapeMedallions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypePortraits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTypePortrait = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePortraits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTypeText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTexts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorMedallions");

            migrationBuilder.DropTable(
                name: "MedallionMaterials");

            migrationBuilder.DropTable(
                name: "ShapeMedallions");

            migrationBuilder.DropTable(
                name: "TypePortraits");

            migrationBuilder.DropTable(
                name: "TypeTexts");

            migrationBuilder.DropColumn(
                name: "DeletedCheck",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "DeletedCheck",
                table: "Deceaseds");

            migrationBuilder.DropColumn(
                name: "DeletedCheck",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "PhotoOnMonuments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_ContractId",
                table: "PhotoOnMonuments",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_Contracts_ContractId",
                table: "PhotoOnMonuments",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
