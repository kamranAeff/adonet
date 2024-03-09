using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOrm.Models.Configurations
{
    class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(130).IsRequired();
            builder.Property(m => m.Slug).HasColumnType("varchar").HasMaxLength(130).IsRequired();
            builder.Property(m => m.StockKeepingUnit).HasColumnType("varchar").HasMaxLength(70).IsRequired();
            builder.Property(m => m.ShortDescription).HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
            builder.Property(m => m.Description).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(m => m.Rate).HasColumnType("decimal").HasPrecision(18, 2).IsRequired();
            builder.Property(m => m.BrandId).HasColumnType("int").IsRequired();

            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Products");



            builder.HasOne<Brand>()
                .WithMany()
                .HasForeignKey(m => m.BrandId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
