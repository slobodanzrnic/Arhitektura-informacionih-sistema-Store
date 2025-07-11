using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers {  get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Jackets", DisplayOrder = 1 },
                new Category { Id = 2, Name = "T-shirts", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Sweaters", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Planeta Sport", StreetAddress="Bulevar oslobodjenja 1",  City="Novi Sad", PhoneNumber="0621234567", PostalCode= "21000", State= "Novi Sad"},
                new Company { Id = 2, Name = "Inter Sport", StreetAddress = "Bulevar oslobodjenja 20", City = "Novi Sad", PhoneNumber = "062112167", PostalCode = "21000", State = "Novi Sad" },
                new Company { Id = 3, Name = "Djak", StreetAddress = "Bulevar oslobodjenja 46", City = "Novi Sad", PhoneNumber = "0621264447", PostalCode = "21000", State = "Novi Sad" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Club Fleece Sweatshirt",
                    Manufacturer = "Nike",
                    Description = "A cozy and comfortable sweatshirt made from soft fleece, perfect for everyday wear or post-workout relaxation",
                    Price = 100,
                    Price2 = 85,
                    Price3 = 70,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "Air Pullover",
                    Manufacturer = "Nike",
                    Description = "A lightweight, breathable pullover designed for maximum comfort, keeping you cool and stylish throughout the day.",
                    Price = 110,
                    Price2 = 100,
                    Price3 = 90,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "Sportswear Essential",
                    Manufacturer = "Nike",
                    Description = "An essential piece for any active lifestyle, this sportswear is designed for optimal performance and everyday comfort.",
                    Price = 80,
                    Price2 = 75,
                    Price3 = 70,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Name = "Danda Flame",
                    Manufacturer = "Hugo Boss",
                    Description = "A sleek and modern design with a bold flame pattern, adding a touch of edge to your casual look.",
                    Price = 70,
                    Price2 = 65,
                    Price3 = 60,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Name = "Dikobra",
                    Manufacturer = "Hugo Boss",
                    Description = "A stylish and versatile piece with sharp, clean lines for a sophisticated yet casual appearance.",
                    Price = 90,
                    Price2 = 85,
                    Price3 = 80,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Name = "Regular Fit",
                    Manufacturer = "Hugo Boss",
                    Description = "Timeless and classic, this regular-fit piece offers a comfortable fit for all-day wear.",
                    Price = 100,
                    Price2 = 95,
                    Price3 = 85,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 7,
                    Name = "Original fit",
                    Manufacturer = "Adidas",
                    Description = "Designed for those who prefer a traditional yet tailored look, this piece combines comfort with a perfect fit.",
                    Price = 150,
                    Price2 = 135,
                    Price3 = 115,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Name = "Run It",
                    Manufacturer = "Adidas",
                    Description = "Engineered for performance and style, this piece is perfect for runners or anyone who values movement and comfort.",
                    Price = 180,
                    Price2 = 160,
                    Price3 = 135,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Name = "Skate Black & White",
                    Manufacturer = "Adidas",
                    Description = "Classic black and white design with durable construction, ideal for skaters or anyone who appreciates a street-style look.",
                    Price = 150,
                    Price2 = 140,
                    Price3 = 130,
                    CategoryId = 1,
                    ImageUrl = ""
                });
        }

    }
}
