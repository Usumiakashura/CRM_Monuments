using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class EntitiesMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameTypeText",
                table: "TypeTexts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameTypePortrait",
                table: "TypePortraits",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameShape",
                table: "ShapeMedallions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameMaterial",
                table: "MedallionMaterials",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameColor",
                table: "ColorMedallions",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TypeTexts",
                newName: "NameTypeText");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TypePortraits",
                newName: "NameTypePortrait");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ShapeMedallions",
                newName: "NameShape");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MedallionMaterials",
                newName: "NameMaterial");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ColorMedallions",
                newName: "NameColor");
        }
    }
}
