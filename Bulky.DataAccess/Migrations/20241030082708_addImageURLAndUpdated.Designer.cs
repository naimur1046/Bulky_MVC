﻿// <auto-generated />
using BulkyBook.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyBook.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241030082708_addImageURLAndUpdated")]
    partial class addImageURLAndUpdated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkyBook.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = "1",
                            Name = "Naimur Rahman"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = "2",
                            Name = "Tonmoy Ahmed"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = "3",
                            Name = "Naim Tahsin"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = "5",
                            Name = "Zawadul Karim"
                        });
                });

            modelBuilder.Entity("BulkyBook.Models.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Author 1",
                            CategoryId = 3,
                            ISBN = "123-4567890123",
                            ImageURL = "k",
                            ListPrice = 100.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Author 2",
                            CategoryId = 1,
                            ISBN = "234-5678901234",
                            ImageURL = "d",
                            ListPrice = 120.0,
                            Price = 110.0,
                            Price100 = 100.0,
                            Price50 = 105.0,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Author 3",
                            CategoryId = 2,
                            ISBN = "345-6789012345",
                            ImageURL = "g",
                            ListPrice = 150.0,
                            Price = 140.0,
                            Price100 = 125.0,
                            Price50 = 130.0,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Author 4",
                            CategoryId = 4,
                            ISBN = "456-7890123456",
                            ImageURL = "g",
                            ListPrice = 180.0,
                            Price = 170.0,
                            Price100 = 150.0,
                            Price50 = 160.0,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Author 5",
                            CategoryId = 5,
                            ISBN = "567-8901234567",
                            ImageURL = "d",
                            ListPrice = 200.0,
                            Price = 190.0,
                            Price100 = 175.0,
                            Price50 = 180.0,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Author 6",
                            CategoryId = 6,
                            ISBN = "678-9012345678",
                            ImageURL = "r",
                            ListPrice = 250.0,
                            Price = 240.0,
                            Price100 = 225.0,
                            Price50 = 230.0,
                            Title = "Product 6"
                        });
                });

            modelBuilder.Entity("BulkyBook.Models.Models.Product", b =>
                {
                    b.HasOne("BulkyBook.Models.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
