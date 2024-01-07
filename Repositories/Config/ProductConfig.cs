using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.ProductPrice).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/1.png", ProductName = "Ottoman Wedding", ProductPrice = 30_000 },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/2.png", ProductName = "Romanian Wedding", ProductPrice = 32_000 },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/3.png", ProductName = "Russian Wedding", ProductPrice = 20_000 },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/4.png", ProductName = "French Wedding", ProductPrice = 15_000 },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/5.png", ProductName = "Standart Turkish Wedding", ProductPrice = 7_000 },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/6.png", ProductName = "Nordic Wedding", ProductPrice = 10_000 },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/7.png", ProductName = "Chair", ProductPrice = 100 }
            );
        }
    }
}