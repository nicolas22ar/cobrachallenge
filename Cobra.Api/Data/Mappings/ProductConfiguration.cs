using Cobra.Domain.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Cobra.Api.Data.Mappings
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => x.Name);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.HasIndex(x => x.ProductId);

            builder.Property(x => x.ProductId)
                .IsRequired()
                .HasColumnType("varchar(10)");
        }
    }
}
