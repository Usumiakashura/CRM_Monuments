using DataLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class EFDBContext : /*DbContext, */IdentityDbContext<ApplicationUser>
    {
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Stella> Stellas { get; set; }
        public DbSet<Deceased> Deceaseds { get; set; }
        public DbSet<TextOnStella> TextOnStellas { get; set; }
        public DbSet<Epitaph> Epitaphs { get; set; }
        public DbSet<Medallion> Medallions { get; set; }
        public DbSet<PhotoOnMonument> PhotoOnMonuments { get; set; }
        public DbSet<Portrait> Portraits { get; set; }

        public DbSet<TypeText> TypeTexts { get; set; }
        public DbSet<TypePortrait> TypePortraits { get; set; }
        public DbSet<MedallionMaterial> MedallionMaterials { get; set; }
        public DbSet<ShapeMedallion> ShapeMedallions { get; set; }
        public DbSet<MedallionSize> MedallionSizes { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<MedallionMaterial>()
                .HasMany(c => c.MedallionSizes)
                .WithMany(s => s.MedallionMaterials)
                .UsingEntity<MedallionPrice>(
                    j => j
                    .HasOne(pt => pt.MedallionSize)
                    .WithMany(t => t.MedallionPrices)
                    .HasForeignKey(pt => pt.MedallionSizeId),
                    j => j
                    .HasOne(pt => pt.MedallionMaterial)
                    .WithMany(p => p.MedallionPrices)
                    .HasForeignKey(pt => pt.MedallionMaterialId),
                    j =>
                    {
                        j.Property(pt => pt.Price).HasDefaultValue(0);
                        j.HasKey(t => new { t.MedallionMaterialId, t.MedallionSizeId });
                        j.ToTable("MedallionPrices");
                    });
            base.OnModelCreating(modelBuilder);
        }
    }
}
