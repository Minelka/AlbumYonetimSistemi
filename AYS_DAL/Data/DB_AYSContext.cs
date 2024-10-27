using AYS_DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Data

{
    public class DB_AYSContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Album> Albums { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Admin admin = new Admin()
            {
                Id = 1,
                Name = "Göksel",
                Password = "password123",
                Created = new DateTime(2024,10,10,11,43,33,234,DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Admin>().HasData(admin);

            new Admin()
            {
                Id = 2,
                Name = "Minel",
                Password = "password123",
                Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Admin>().HasData(admin);

            new Admin()
            {
                Id = 2,
                Name = "Efnan",
                Password = "password123",
                Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Admin>().HasData(admin);

            Album album = new Album()
            {
                Id = 1,
                Name = "Mesafe",
                Artist = "Serdar Ortaç",
                ReleaseDate = new DateOnly(2006, 01, 05),
                Price = 55,
                Discount = 0,                
                Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Album>().HasData(album);

            new Album
            {
                Id = 2,
                Name = "onyedi",
                Artist = "Teoman",
                ReleaseDate = new DateOnly(2000, 28, 04),
                Price = 975,
                Discount = 0.10m,
                Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Album>().HasData(album);

            new Album
            {
                Id = 3,
                Name = "Touch",
                Artist = "Eurythmics",
                ReleaseDate = new DateOnly(1983, 01, 01),
                Price = 450,
                Discount = 0.2m,
                Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Album>().HasData(album);

            new Album
            {
                Id = 4,
                Name = "Gönül Sayfam",
                Artist = "Kayahan",
                ReleaseDate = new DateOnly(2000, 01, 01),
                Price = 975,
                Discount = 0,
                Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Album>().HasData(album);

            new Album
            {
                Id = 5,
                Name = "Akustik Travma",
                Artist = "Yüzyüzeyken Konuşuruz",
                ReleaseDate = new DateOnly(2018, 01, 01),
                Price = 975,
                Discount = 0,
                Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<Album>().HasData(album);



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string serverMinel = "DESKTOP-J5485VO";
            string serverEfnan = "DESKTOP-VAQBE6U";

            string connStr = $"Server={serverEfnan};Database=AYS_DB;Trusted_Connection=true;Trustservercertificate=true";

            optionsBuilder.UseSqlServer(connStr);
        }

    }
}
