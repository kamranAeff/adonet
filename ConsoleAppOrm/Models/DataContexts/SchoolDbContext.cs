using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppOrm.Models.DataContexts
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Database=SchoolDb;User Id=adonet;Password=query;Encrypt=false;App=Orm",
                opt =>
                {
                    opt.MigrationsHistoryTable("MigrationHistory");
                });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolDbContext).Assembly);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
