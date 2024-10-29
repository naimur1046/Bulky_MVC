using BulkyBook.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Naimur Rahman",
                    DisplayOrder = "1"

                },
                new Category
                {
                    Id = 2,
                    Name = "Tonmoy Ahmed",
                    DisplayOrder = "2"

                },
                new Category
                {
                    Id = 3,
                    Name = "Naim Tahsin",
                    DisplayOrder = "3"

                },
                new Category
                {
                    Id = 4,
                    Name = "Zawadul Karim",
                    DisplayOrder = "5"

                }
                );
            

                
        }

    }
}
