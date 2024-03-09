using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppOrm.Models.Configurations
{
    class SizeEntityTypeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.SmallName).HasColumnType("varchar").HasMaxLength(10).IsRequired();

            builder.ConfigureAuditable();


            builder.HasKey(m => m.Id);
            builder.ToTable("Sizes");
        }
    }
}
