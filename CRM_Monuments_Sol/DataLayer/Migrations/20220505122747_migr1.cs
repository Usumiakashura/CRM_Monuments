using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class migr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Viber = table.Column<bool>(type: "bit", nullable: false),
                    Telegram = table.Column<bool>(type: "bit", nullable: false),
                    WhatsApp = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    DateBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRip = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<bool>(type: "bit", nullable: false),
                    TypeTextObjId = table.Column<int>(type: "int", nullable: true),
                    NotesTextName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngraverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBeginTextName = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCompleatTextName = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Deceaseds_TypeTexts_TypeTextObjId",
                        column: x => x.TypeTextObjId,
                        principalTable: "TypeTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Epitaphs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EpitaphBool = table.Column<bool>(type: "bit", nullable: false),
                    TypeTextObjId = table.Column<int>(type: "int", nullable: true),
                    NotesTextEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngraverEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBeginTextEpitaph = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCompleatTextEpitaph = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epitaphs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Epitaphs_Deceaseds_Id",
                        column: x => x.Id,
                        principalTable: "Deceaseds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Epitaphs_TypeTexts_TypeTextObjId",
                        column: x => x.TypeTextObjId,
                        principalTable: "TypeTexts",
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
                    PhotoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCompleat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeceasedId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedallionMaterialObjId = table.Column<int>(type: "int", nullable: true),
                    SizeMedallion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShapeMedallionObjId = table.Column<int>(type: "int", nullable: true),
                    ColorMedallionObjId = table.Column<int>(type: "int", nullable: true),
                    BackgroundMedallion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frame = table.Column<bool>(type: "bit", nullable: true),
                    TypeFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShapeFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GluingIntoNiche = table.Column<bool>(type: "bit", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypePortraitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoOnMonuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoOnMonuments_ColorMedallions_ColorMedallionObjId",
                        column: x => x.ColorMedallionObjId,
                        principalTable: "ColorMedallions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoOnMonuments_Deceaseds_DeceasedId",
                        column: x => x.DeceasedId,
                        principalTable: "Deceaseds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoOnMonuments_MedallionMaterials_MedallionMaterialObjId",
                        column: x => x.MedallionMaterialObjId,
                        principalTable: "MedallionMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoOnMonuments_ShapeMedallions_ShapeMedallionObjId",
                        column: x => x.ShapeMedallionObjId,
                        principalTable: "ShapeMedallions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitId",
                        column: x => x.TypePortraitId,
                        principalTable: "TypePortraits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ContractId",
                table: "Customers",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Deceaseds_ContractId",
                table: "Deceaseds",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Deceaseds_TypeTextObjId",
                table: "Deceaseds",
                column: "TypeTextObjId");

            migrationBuilder.CreateIndex(
                name: "IX_Epitaphs_TypeTextObjId",
                table: "Epitaphs",
                column: "TypeTextObjId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_ColorMedallionObjId",
                table: "PhotoOnMonuments",
                column: "ColorMedallionObjId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_DeceasedId",
                table: "PhotoOnMonuments",
                column: "DeceasedId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_MedallionMaterialObjId",
                table: "PhotoOnMonuments",
                column: "MedallionMaterialObjId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_ShapeMedallionObjId",
                table: "PhotoOnMonuments",
                column: "ShapeMedallionObjId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_TypePortraitId",
                table: "PhotoOnMonuments",
                column: "TypePortraitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Epitaphs");

            migrationBuilder.DropTable(
                name: "PhotoOnMonuments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ColorMedallions");

            migrationBuilder.DropTable(
                name: "Deceaseds");

            migrationBuilder.DropTable(
                name: "MedallionMaterials");

            migrationBuilder.DropTable(
                name: "ShapeMedallions");

            migrationBuilder.DropTable(
                name: "TypePortraits");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "TypeTexts");
        }
    }
}
