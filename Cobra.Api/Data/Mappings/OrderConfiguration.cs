using Cobra.Domain.Domain;
using Cobra.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Cobra.Api.Data.Mappings
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasIndex(x => x.MethodPurchase);

            builder.Property(x => x.MethodPurchase)
                .HasColumnType("varchar(255)");


            builder.HasOne(x => x.Person)
                .WithOne()
                .HasForeignKey<Person>(x => x.Id);
        }
    }
}
