using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppOrm.Models.Configurations
{
    class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            builder.ConfigureAuditable();


            builder.HasKey(m=>m.Id);
            builder.ToTable("Brands");
        }
    }
}
