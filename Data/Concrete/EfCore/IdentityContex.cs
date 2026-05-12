using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESaat.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ESaat.Data.Concrete.EfCore
{
    public class IdentityContex:IdentityDbContext<ApplicationUser>
    {
        public IdentityContex(DbContextOptions<IdentityContex> options):base(options)
        {
            
        }
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

             

           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var hasher = new PasswordHasher<ApplicationUser>();

            // Kullanıcılar
            var user1 = new ApplicationUser
            {
                Id = "1",
                UserName = "omerapaydin",
                Email = "info@gmail.com",
                ImageFile = "p1.jpg",
                FullName = "Ömer Apaydın",
                EmailConfirmed = true
            };
            user1.PasswordHash = hasher.HashPassword(user1, "User123!");

            var user2 = new ApplicationUser
            {
                Id = "2",
                UserName = "ahmettambuga",
                Email = "info2@gmail.com",
                ImageFile = "p2.jpg",
                FullName = "Ahmet Tamboğa",
                EmailConfirmed = true
            };
            user2.PasswordHash = hasher.HashPassword(user2, "User2Password!");

            modelBuilder.Entity<ApplicationUser>().HasData(user1, user2);

            // Kategoriler
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Metal Saat" },
                new Category { CategoryId = 2, Name = "Akıllı Saat" },
                new Category { CategoryId = 3, Name = "Çelik Saat" }
            );

            // Ürünler
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Title = "SANTOS DE CARTIER SAAT",
                Description = "Büyük boy model, otomatik mekanizma, ADLC çelik.",
                PublishedOn = new DateTime(2024, 1, 1),  
                Image = "saat1.jpeg",
                Price = 489000,
                IsActive = true,
                UserId = "1",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 2,
                Title = "SANTOS DE CARTIER SAAT",
                Description = "Büyük boy model, otomatik mekanizma, ADLC çelik.",
                PublishedOn = new DateTime(2024, 2, 1),  
                Image = "saat2.jpeg",
                Price = 489000,
                IsActive = true,
                UserId = "1",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 3,
                Title = "PANTHÈRE DE CARTIER SAAT",
                Description = "Küçük model, kuvars mekanizma, sarı altın.",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "saat3.jpeg",
                Price = 492000,
                IsActive = true,
                UserId = "2",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 4,
                Title = "TANK  ",
                Description = "Olağanüstü forma ve tasarıma sahip bir saat.",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "saat4.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "2",
                CategoryId = 2
            },
            new Product
            {
                ProductId = 5,
                Title = "VENDÔME LOUIS CARTIER",
                Description = "Olağanüstü forma ve tasarıma sahip bir saat.",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "saat5.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "2",
                CategoryId = 2
            },
            new Product
            {
                ProductId = 6,
                Title = "TANK",
                Description = "Olağanüstü forma ve tasarıma sahip bir saat.",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "saat6.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "2",
                CategoryId = 3
            }
        );
        }

    }
}