using Microsoft.EntityFrameworkCore;

namespace RecordsManagement.Models
{
    public class RecordContext : DbContext
    {

        public RecordContext(DbContextOptions<RecordContext> options)
            : base(options)
        { }

        public DbSet<Record> Records { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "1", Name = "Clothing" },
                new Category { CategoryId = "2", Name = "Electronics" },
                new Category { CategoryId = "3", Name = "Food and Grocery" },
                new Category { CategoryId = "4", Name = "Home and Garden" }
            );

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { WarehouseId = "1", Name = "Chicago" },
                new Warehouse { WarehouseId = "2", Name = "New York" },
                new Warehouse { WarehouseId = "3", Name = "San Francisco" },
                new Warehouse { WarehouseId = "4", Name = "Miami" }
            );
        }
    }
}