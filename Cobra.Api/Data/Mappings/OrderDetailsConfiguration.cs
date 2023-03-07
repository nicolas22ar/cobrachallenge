using Cobra.Domain.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Cobra.Api.Data.Mappings
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasIndex(x => x.OrderNumber);

            builder.HasOne(x => x.Order)
                .WithOne()
                .HasForeignKey<Order>(x => x.Id);

            builder.HasOne(x => x.Product)
               .WithOne()
               .HasForeignKey<Product>(x => x.Id);
        }
    }
}
