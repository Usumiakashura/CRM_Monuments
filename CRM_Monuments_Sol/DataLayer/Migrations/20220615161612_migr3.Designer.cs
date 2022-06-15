﻿// <auto-generated />
using System;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(EFDBContext))]
    [Migration("20220615161612_migr3")]
    partial class migr3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DataLayer.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BurialAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BurialPlace")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfConclusion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decoration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DistanceFromMKAD")
                        .HasColumnType("int");

                    b.Property<int?>("Grave")
                        .HasColumnType("int");

                    b.Property<bool>("InstallmentPayment")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteInstaller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteProduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfTrips")
                        .HasColumnType("int");

                    b.Property<bool>("Pickup")
                        .HasColumnType("bit");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Row")
                        .HasColumnType("int");

                    b.Property<int?>("Sector")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("DataLayer.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContractId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Telegram")
                        .HasColumnType("bit");

                    b.Property<bool>("Viber")
                        .HasColumnType("bit");

                    b.Property<bool>("WhatsApp")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DataLayer.Entities.Deceased", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Photo")
                        .HasColumnType("bit");

                    b.Property<int?>("StellaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StellaId");

                    b.ToTable("Deceaseds");
                });

            modelBuilder.Entity("DataLayer.Entities.Epitaph", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBeginTextEpitaph")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCompleatTextEpitaph")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeceasedId")
                        .HasColumnType("int");

                    b.Property<string>("EngraverEpitaph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotesTextEpitaph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeTextId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeceasedId");

                    b.HasIndex("TypeTextId");

                    b.ToTable("Epitaphs");
                });

            modelBuilder.Entity("DataLayer.Entities.MedallionMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedallionMaterials");
                });

            modelBuilder.Entity("DataLayer.Entities.MedallionPrice", b =>
                {
                    b.Property<int?>("MedallionMaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("MedallionSizeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.HasKey("MedallionMaterialId", "MedallionSizeId");

                    b.HasIndex("MedallionSizeId");

                    b.ToTable("MedallionPrices");
                });

            modelBuilder.Entity("DataLayer.Entities.MedallionSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedallionSizes");
                });

            modelBuilder.Entity("DataLayer.Entities.PhotoOnMonument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCompleat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeceasedId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeceasedId");

                    b.ToTable("PhotoOnMonuments");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PhotoOnMonument");
                });

            modelBuilder.Entity("DataLayer.Entities.ShapeMedallion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShapeMedallions");
                });

            modelBuilder.Entity("DataLayer.Entities.Stella", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContractId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("Stellas");
                });

            modelBuilder.Entity("DataLayer.Entities.TextOnStella", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBeginTextOnStella")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateBirthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCompleatTextOnStella")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRip")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeceasedId")
                        .HasColumnType("int");

                    b.Property<string>("EngraverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotesTextName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeTextId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeceasedId")
                        .IsUnique()
                        .HasFilter("[DeceasedId] IS NOT NULL");

                    b.HasIndex("TypeTextId");

                    b.ToTable("TextOnStellas");
                });

            modelBuilder.Entity("DataLayer.Entities.TypePortrait", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypePortraits");
                });

            modelBuilder.Entity("DataLayer.Entities.TypeText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeTexts");
                });

            modelBuilder.Entity("MedallionMaterialShapeMedallion", b =>
                {
                    b.Property<int>("MedallionMaterialsId")
                        .HasColumnType("int");

                    b.Property<int>("ShapesMedallionId")
                        .HasColumnType("int");

                    b.HasKey("MedallionMaterialsId", "ShapesMedallionId");

                    b.HasIndex("ShapesMedallionId");

                    b.ToTable("MedallionMaterialShapeMedallion");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DataLayer.Entities.Medallion", b =>
                {
                    b.HasBaseType("DataLayer.Entities.PhotoOnMonument");

                    b.Property<string>("BackgroundMedallion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorMedallion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Frame")
                        .HasColumnType("bit");

                    b.Property<bool>("GluingIntoNiche")
                        .HasColumnType("bit");

                    b.Property<int?>("MedallionMaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("MedallionSizeId")
                        .HasColumnType("int");

                    b.Property<string>("NoteFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShapeFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShapeMedallionId")
                        .HasColumnType("int");

                    b.Property<string>("SizeFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMedallion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeFrame")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("MedallionMaterialId");

                    b.HasIndex("MedallionSizeId");

                    b.HasIndex("ShapeMedallionId");

                    b.HasDiscriminator().HasValue("Medallion");
                });

            modelBuilder.Entity("DataLayer.Entities.Portrait", b =>
                {
                    b.HasBaseType("DataLayer.Entities.PhotoOnMonument");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypePortraitId")
                        .HasColumnType("int");

                    b.HasIndex("TypePortraitId");

                    b.HasDiscriminator().HasValue("Portrait");
                });

            modelBuilder.Entity("DataLayer.Entities.Customer", b =>
                {
                    b.HasOne("DataLayer.Entities.Contract", "Contract")
                        .WithMany("Customers")
                        .HasForeignKey("ContractId");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("DataLayer.Entities.Deceased", b =>
                {
                    b.HasOne("DataLayer.Entities.Stella", "Stella")
                        .WithMany("Deceaseds")
                        .HasForeignKey("StellaId");

                    b.Navigation("Stella");
                });

            modelBuilder.Entity("DataLayer.Entities.Epitaph", b =>
                {
                    b.HasOne("DataLayer.Entities.Deceased", "Deceased")
                        .WithMany("Epitaphs")
                        .HasForeignKey("DeceasedId");

                    b.HasOne("DataLayer.Entities.TypeText", "TypeText")
                        .WithMany("Epitaphs")
                        .HasForeignKey("TypeTextId");

                    b.Navigation("Deceased");

                    b.Navigation("TypeText");
                });

            modelBuilder.Entity("DataLayer.Entities.MedallionPrice", b =>
                {
                    b.HasOne("DataLayer.Entities.MedallionMaterial", "MedallionMaterial")
                        .WithMany("MedallionPrices")
                        .HasForeignKey("MedallionMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.MedallionSize", "MedallionSize")
                        .WithMany("MedallionPrices")
                        .HasForeignKey("MedallionSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedallionMaterial");

                    b.Navigation("MedallionSize");
                });

            modelBuilder.Entity("DataLayer.Entities.PhotoOnMonument", b =>
                {
                    b.HasOne("DataLayer.Entities.Deceased", "Deceased")
                        .WithMany("PhotosOnMonument")
                        .HasForeignKey("DeceasedId");

                    b.Navigation("Deceased");
                });

            modelBuilder.Entity("DataLayer.Entities.Stella", b =>
                {
                    b.HasOne("DataLayer.Entities.Contract", "Contract")
                        .WithMany("Stellas")
                        .HasForeignKey("ContractId");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("DataLayer.Entities.TextOnStella", b =>
                {
                    b.HasOne("DataLayer.Entities.Deceased", "Deceased")
                        .WithOne("TextOnStella")
                        .HasForeignKey("DataLayer.Entities.TextOnStella", "DeceasedId");

                    b.HasOne("DataLayer.Entities.TypeText", "TypeText")
                        .WithMany("TextOnStellas")
                        .HasForeignKey("TypeTextId");

                    b.Navigation("Deceased");

                    b.Navigation("TypeText");
                });

            modelBuilder.Entity("MedallionMaterialShapeMedallion", b =>
                {
                    b.HasOne("DataLayer.Entities.MedallionMaterial", null)
                        .WithMany()
                        .HasForeignKey("MedallionMaterialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.ShapeMedallion", null)
                        .WithMany()
                        .HasForeignKey("ShapesMedallionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DataLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataLayer.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Entities.Medallion", b =>
                {
                    b.HasOne("DataLayer.Entities.MedallionMaterial", "MedallionMaterial")
                        .WithMany("Medallions")
                        .HasForeignKey("MedallionMaterialId");

                    b.HasOne("DataLayer.Entities.MedallionSize", "MedallionSize")
                        .WithMany("Medallions")
                        .HasForeignKey("MedallionSizeId");

                    b.HasOne("DataLayer.Entities.ShapeMedallion", "ShapeMedallion")
                        .WithMany("Medallions")
                        .HasForeignKey("ShapeMedallionId");

                    b.Navigation("MedallionMaterial");

                    b.Navigation("MedallionSize");

                    b.Navigation("ShapeMedallion");
                });

            modelBuilder.Entity("DataLayer.Entities.Portrait", b =>
                {
                    b.HasOne("DataLayer.Entities.TypePortrait", "TypePortrait")
                        .WithMany("Portraits")
                        .HasForeignKey("TypePortraitId");

                    b.Navigation("TypePortrait");
                });

            modelBuilder.Entity("DataLayer.Entities.Contract", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Stellas");
                });

            modelBuilder.Entity("DataLayer.Entities.Deceased", b =>
                {
                    b.Navigation("Epitaphs");

                    b.Navigation("PhotosOnMonument");

                    b.Navigation("TextOnStella");
                });

            modelBuilder.Entity("DataLayer.Entities.MedallionMaterial", b =>
                {
                    b.Navigation("MedallionPrices");

                    b.Navigation("Medallions");
                });

            modelBuilder.Entity("DataLayer.Entities.MedallionSize", b =>
                {
                    b.Navigation("MedallionPrices");

                    b.Navigation("Medallions");
                });

            modelBuilder.Entity("DataLayer.Entities.ShapeMedallion", b =>
                {
                    b.Navigation("Medallions");
                });

            modelBuilder.Entity("DataLayer.Entities.Stella", b =>
                {
                    b.Navigation("Deceaseds");
                });

            modelBuilder.Entity("DataLayer.Entities.TypePortrait", b =>
                {
                    b.Navigation("Portraits");
                });

            modelBuilder.Entity("DataLayer.Entities.TypeText", b =>
                {
                    b.Navigation("Epitaphs");

                    b.Navigation("TextOnStellas");
                });
#pragma warning restore 612, 618
        }
    }
}
