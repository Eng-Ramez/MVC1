using Microsoft.EntityFrameworkCore;
using Session1.Models;

namespace Session1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Category> categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=MVC1;trusted_connection=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                     new Category { Id=1,Name="Ramez 1"},
                     new Category { Id=2,Name="Ramez 2"},
                     new Category { Id=3,Name="Ramez 3"}
                );
                
                
                
            
            
        }

    }
}
