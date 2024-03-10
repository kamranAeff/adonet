using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppOrm.Models.Configurations
{
    class SpecificationValueEntityTypeConfiguration : IEntityTypeConfiguration<SpecificationValue>
    {
        public void Configure(EntityTypeBuilder<SpecificationValue> builder)
        {
            builder.Property(m => m.ProductId).HasColumnType("int");
            builder.Property(m => m.SpecificationId).HasColumnType("int");
            builder.Property(m => m.Value).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();


            builder.HasKey(m => new { m.ProductId, m.SpecificationId });
            builder.ToTable("SpecificationValues");
        }
    }
}
