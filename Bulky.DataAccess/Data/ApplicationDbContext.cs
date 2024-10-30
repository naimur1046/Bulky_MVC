using BulkyBook.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        
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
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Product 1",
                    ISBN = "123-4567890123",
                    Author = "Author 1",
                    ListPrice = 100.0,
                    Price = 90.0,
                    Price50 = 85.0,
                    Price100 = 80.0,
                    CategoryId = 3,
                    ImageURL="k"
                },
           new Product
{
    Id = 2,
    Title = "Product 2",
    ISBN = "234-5678901234",
    Author = "Author 2",
    ListPrice = 120.0,
    Price = 110.0,
    Price50 = 105.0,
    Price100 = 100.0,
    CategoryId = 1,
    ImageURL="d"
},
new Product
{
    Id = 3,
    Title = "Product 3",
    ISBN = "345-6789012345",
    Author = "Author 3",
    ListPrice = 150.0,
    Price = 140.0,
    Price50 = 130.0,
    Price100 = 125.0,
    CategoryId = 2,
    ImageURL="g",
},
new Product
{
    Id = 4,
    Title = "Product 4",
    ISBN = "456-7890123456",
    Author = "Author 4",
    ListPrice = 180.0,
    Price = 170.0,
    Price50 = 160.0,
    Price100 = 150.0,
    CategoryId = 4,
    ImageURL="g",
},
new Product
{
    Id = 5,
    Title = "Product 5",
    ISBN = "567-8901234567",
    Author = "Author 5",
    ListPrice = 200.0,
    Price = 190.0,
    Price50 = 180.0,
    Price100 = 175.0,
    CategoryId = 5,
    ImageURL="d",
},
new Product
{
    Id = 6,
    Title = "Product 6",
    ISBN = "678-9012345678",
    Author = "Author 6",
    ListPrice = 250.0,
    Price = 240.0,
    Price50 = 230.0,
    Price100 = 225.0,
    CategoryId = 6,
    ImageURL="r"
}
                );


        }

    }
}
