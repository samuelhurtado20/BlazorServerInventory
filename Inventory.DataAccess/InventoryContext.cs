using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.DataAccess;

public class InventoryContext : DbContext
{
    public DbSet<CategoryEntity> Categories { get; set; }

    public DbSet<ProductEntity> Products { get; set; }

    public DbSet<WarehouseEntity> Warehouses { get; set; }

    public DbSet<StorageEntity> Storages { get; set; }

    public DbSet<InOutEntity> InOuts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = "Data Source=SAMUEL\\MSSQLSERVER01;Initial Catalog=BlazorInventory;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CategoryEntity>().HasData(
          new CategoryEntity { Id = 1, CategoryCode = "ASH", CategoryName = "Aseo Hogar" },
          new CategoryEntity { Id = 2, CategoryCode = "ASP", CategoryName = "Aseo Personal" },
          new CategoryEntity { Id = 3, CategoryCode = "HGR", CategoryName = "Hogar" },
          new CategoryEntity { Id = 4, CategoryCode = "PRF", CategoryName = "Perfumería" },
          new CategoryEntity { Id = 5, CategoryCode = "SLD", CategoryName = "Salud" },
          new CategoryEntity { Id = 6, CategoryCode = "VDJ", CategoryName = "Video Juegos" }
          );
    }
}