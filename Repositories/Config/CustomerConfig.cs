using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(a=>a.CustomerId);

            builder.Property(a=>a.CustomerName).IsRequired();
            builder.Property(a=>a.CustomerMail).IsRequired();
            builder.Property(a=>a.CustomerPassword).IsRequired();

            builder.HasData(
                new Customer(){CustomerId=1,CustomerMail="basartuna35@gmail.com",CustomerName="Tuna",CustomerPassword=123},
                new Customer(){CustomerId=2,CustomerMail="ymanbasarbasar@gmail.com",CustomerName="Hilmi",CustomerPassword=12345}
            );
        }
    }
}