using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Cobra.Domain.Domain;

namespace Cobra.Api.Data.Mappings
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasIndex(x => x.FirstName);

            builder.HasIndex(x => x.LastName);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("varchar(255)");
        }
    }
}
