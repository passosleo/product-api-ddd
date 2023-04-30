using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Migrations
{
    public class ProductMap : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("PRODUCTS");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Title)
                .IsUnique();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(c => c.Category)
                .WithMany();

            builder.Property(x => x.Enabled)
                    .HasDefaultValueSql("1");
        }
    }
}
