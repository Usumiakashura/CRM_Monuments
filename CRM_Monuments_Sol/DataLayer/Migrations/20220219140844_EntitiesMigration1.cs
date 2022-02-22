using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class EntitiesMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColorMedallions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorMedallions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfConclusion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstallmentPayment = table.Column<bool>(type: "bit", nullable: false),
                    Pickup = table.Column<bool>(type: "bit", nullable: false),
                    BurialAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Row = table.Column<int>(type: "int", nullable: true),
                    BurialPlace = table.Column<int>(type: "int", nullable: true),
                    Sector = table.Column<int>(type: "int", nullable: true),
                    Grave = table.Column<int>(type: "int", nullable: true),
                    DistanceFromMKAD = table.Column<int>(type: "int", nullable: true),
                    NumberOfTrips = table.Column<int>(type: "int", nullable: true),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Decoration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteInstaller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteProduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedallionMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShapeMedallions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoneMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypePortraits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Viber = table.Column<bool>(type: "bit", nullable: false),
                    Telegram = table.Column<bool>(type: "bit", nullable: false),
                    WhatsApp = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedCheck = table.Column<bool>(type: "bit", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deceaseds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBirthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateRip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Photo = table.Column<bool>(type: "bit", nullable: false),
                    TypeNameText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotesTextName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngraverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Epitaph = table.Column<bool>(type: "bit", nullable: false),
                    TypeNameEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotesTextEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngraverEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedCheck = table.Column<bool>(type: "bit", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deceaseds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deceaseds_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    StoneId = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true),
                    Thickness = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessories_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accessories_StoneMaterials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "StoneMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhotoOnMonuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedCheck = table.Column<bool>(type: "bit", nullable: false),
                    DeceasedId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialMedallion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMedallion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShapeMedallion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorMedallion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundMedallion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frame = table.Column<bool>(type: "bit", nullable: true),
                    TypeFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShapeFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GluingIntoNiche = table.Column<bool>(type: "bit", nullable: true),
                    TypePortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoOnMonuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoOnMonuments_Deceaseds_DeceasedId",
                        column: x => x.DeceasedId,
                        principalTable: "Deceaseds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_ContractId",
                table: "Accessories",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_MaterialId",
                table: "Accessories",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ContractId",
                table: "Customers",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Deceaseds_ContractId",
                table: "Deceaseds",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_DeceasedId",
                table: "PhotoOnMonuments",
                column: "DeceasedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "ColorMedallions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MedallionMaterials");

            migrationBuilder.DropTable(
                name: "PhotoOnMonuments");

            migrationBuilder.DropTable(
                name: "ShapeMedallions");

            migrationBuilder.DropTable(
                name: "TypePortraits");

            migrationBuilder.DropTable(
                name: "TypeTexts");

            migrationBuilder.DropTable(
                name: "StoneMaterials");

            migrationBuilder.DropTable(
                name: "Deceaseds");

            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
