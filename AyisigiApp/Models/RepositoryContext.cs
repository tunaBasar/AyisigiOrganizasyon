using Microsoft.EntityFrameworkCore;

namespace AyisigiApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                   new Product() { ProductId = 1, ProductName = "Ottoman Wedding", ProductPrice = 30_000 },
                   new Product() { ProductId = 2, ProductName = "Romanian Wedding", ProductPrice = 32_000 },
                   new Product() { ProductId = 3, ProductName = "Russian Wedding", ProductPrice = 20_000 },
                   new Product() { ProductId = 4, ProductName = "French Wedding", ProductPrice = 15_000 },
                   new Product() { ProductId = 5, ProductName = "Standart Turkish Wedding", ProductPrice = 7_000 }
            );
        }
    }
}