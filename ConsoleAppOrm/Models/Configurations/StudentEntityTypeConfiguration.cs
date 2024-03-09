using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppOrm.Models.Configurations
{
    class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(m => m.Surname).HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(m => m.BirthOfDate).HasColumnType("date");

            builder.HasKey(m=>m.Id);
            builder.ToTable("Students");
        }
    }
}
