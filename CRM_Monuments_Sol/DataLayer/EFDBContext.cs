using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EFDBContext : DbContext
    {
        public DbSet<Accessorie> Accessories { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deceased> Deceaseds { get; set; }
        public DbSet<Medallion> Medallions { get; set; }
        public DbSet<OtherAccessorie> OtherAccessories { get; set; }
        public DbSet<PhotoOnMonument> PhotoOnMonuments { get; set; }
        public DbSet<Portrait> Portraits { get; set; }
        public DbSet<StoneAccessorie> StoneAccessories { get; set; }
        public DbSet<StoneMaterial> StoneMaterials { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
