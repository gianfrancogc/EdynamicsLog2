using EdynamicsLog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EdynamicsLog.Infrastructure.Persistence.Config
{
    public class ProductConfig
    {
        public ProductConfig(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.Property(e => e.Name).IsRequired().HasColumnType("varchar(250)");
            entityBuilder.Property(e => e.Description).IsRequired().HasColumnType("varchar(1800)");
            entityBuilder.Property(e => e.Barcode).IsRequired().HasColumnType("varchar(1800)");
        }
    }
}
