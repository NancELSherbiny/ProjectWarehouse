using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectWarehouse.Files
{
    class CompanyDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UT567QS\\SQLEXPRESS;Database=WarehouseDB;Trusted_Connection=True;Encrypt=False; ");
        }

        public virtual DbSet<Warehouse> Warehouses { get; set; } // Collection of warehouses
        public virtual DbSet<Item> Items { get; set; } // Collection of items
        public virtual DbSet<ItemUnit> ItemUnits { get; set; } // Collection of item units

        public virtual DbSet<Supplier> Suppliers { get; set; } // Collection of suppliers
        public virtual DbSet<Client> Clients { get; set; } // Collection of clients
        public virtual DbSet<SupplyPermit> SupplyPermits { get; set; } // Collection of supply permits
        public virtual DbSet<SupplyPermitItem> SupplyPermitItems { get; set; } // Collection of items in supply permits
       
        public virtual DbSet<WithdrawPermit> WithdrawPermits { get; set; } // Collection of withdraw permits
        public virtual DbSet<WithdrawPermitItem> WithdrawPermitItems { get; set; } // Collection of items in withdraw permits
        public virtual DbSet<Transfer> Transfers { get; set; } // Collection of transfers
        public virtual DbSet<TransferItem> TransferItems { get; set; } // Collection of items in transfers

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.FromWarehouse)
                .WithMany(w => w.TransfersFrom)
                .HasForeignKey(t => t.FromW)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.ToWarehouse)
                .WithMany(w => w.TransfersTo)
                .HasForeignKey(t => t.ToW)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupplyPermitItem>()
                .HasOne(spi => spi.SupplyPermit)
                .WithMany(sp => sp.supplyPermitItems)
                .HasForeignKey(spi => spi.SPID);

            modelBuilder.Entity<WithdrawPermitItem>()
               .HasOne(spi => spi.WithdrawPermit)
               .WithMany(sp => sp.withdrawPermitItems)
               .HasForeignKey(spi => spi.WPID);

        }


    }
}
