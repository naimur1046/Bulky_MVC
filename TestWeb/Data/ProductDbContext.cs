﻿using Microsoft.EntityFrameworkCore;
using TestWeb.Models;

namespace TestWeb.Data
{
    public class ProductDbContext :DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}
