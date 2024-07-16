using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StructureCompany.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Node> Nodes { get; set; }
        public virtual DbSet<Person> Persons { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Node>()
               .HasOne(n => n.Person)
               .WithMany()
               .HasForeignKey(n => n.PersonId);
            modelBuilder.Entity<Node>()
                .HasIndex(n => n.PersonId)
                .IsUnique();
        }


    }

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=WIN-2J6811OHPJK\\SQLEXPRESS;Database=StructureCompanyDB;Trusted_Connection=True;Encrypt=False");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
