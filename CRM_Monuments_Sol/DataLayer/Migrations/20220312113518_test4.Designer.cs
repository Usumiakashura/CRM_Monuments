﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(EFDBContext))]
    [Migration("20220312113518_test4")]
    partial class test4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entities.ColorMedallion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ColorMedallions");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContractId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
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

                    b.Property<int?>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateBeginTextEpitaph")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateBeginTextName")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateBirthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCompleatTextEpitaph")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCompleatTextName")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRip")
                        .HasColumnType("datetime2");

                    b.Property<string>("EngraverEpitaph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngraverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Epitaph")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotesTextEpitaph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotesTextName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Photo")
                        .HasColumnType("bit");

                    b.Property<string>("TypeNameEpitaph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeNameText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("Deceaseds");
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

            modelBuilder.Entity("DataLayer.Entities.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DurationDay")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Times");
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

                    b.Property<string>("MaterialMedallion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShapeFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShapeMedallion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeMedallion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeFrame")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medallion");
                });

            modelBuilder.Entity("DataLayer.Entities.Portrait", b =>
                {
                    b.HasBaseType("DataLayer.Entities.PhotoOnMonument");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypePortraitId")
                        .HasColumnType("int");

                    b.Property<string>("TypePortraitName")
                        .HasColumnType("nvarchar(max)");

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
                    b.HasOne("DataLayer.Entities.Contract", "Contract")
                        .WithMany("Deceaseds")
                        .HasForeignKey("ContractId");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("DataLayer.Entities.PhotoOnMonument", b =>
                {
                    b.HasOne("DataLayer.Entities.Deceased", "Deceased")
                        .WithMany("PhotosOnMonument")
                        .HasForeignKey("DeceasedId");

                    b.Navigation("Deceased");
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

                    b.Navigation("Deceaseds");
                });

            modelBuilder.Entity("DataLayer.Entities.Deceased", b =>
                {
                    b.Navigation("PhotosOnMonument");
                });

            modelBuilder.Entity("DataLayer.Entities.TypePortrait", b =>
                {
                    b.Navigation("Portraits");
                });
#pragma warning restore 612, 618
        }
    }
}
