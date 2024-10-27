using AYS_DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AYS_DAL.Data

{
    public class DB_AYSContext : DbContext
    {
        //Database erişim sağlanır.
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Album> Albums { get; set; }

        //Hashleme metodu oluşturuldu.
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        //Seed data oluşturulur.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Admin>().HasData(
                new Admin()
                {
                    Id = 1,
                    IsActive = true,
                    Name = "Göksel",
                    Password = sha256_hash("password123"),
                    Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                },
                new Admin()
                {
                    Id = 2,
                    IsActive = true,
                    Name = "Minel",
                    Password = sha256_hash("password123"),
                    Created = new DateTime(2023, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                },
                 new Admin()
                 {
                     Id = 3,
                     IsActive = true,
                     Name = "Efnan",
                     Password = sha256_hash("password123"),
                     Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                 },
                 new Admin()
                 {
                     Id = 4,
                     IsActive = true,
                     Name = "Mustafa",
                     Password = sha256_hash("password123"),
                     Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                 });



            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 1,
                    Name = "Mesafe",
                    Artist = "Serdar Ortaç",
                    ReleaseDate = new DateOnly(2006, 01, 05),
                    Price = 55,
                    Discount = 0,
                    Status = true,
                    Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                },
                new Album
                {
                    Id = 2,
                    Name = "onyedi",
                    Artist = "Teoman",
                    ReleaseDate = new DateOnly(2000, 04, 28),
                    Price = 975,
                    Discount = 0.10m,
                    Status = true,
                    Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                },
                new Album
                {
                    Id = 3,
                    Name = "Touch",
                    Artist = "Eurythmics",
                    ReleaseDate = new DateOnly(1983, 01, 01),
                    Price = 450,
                    Discount = 0.2m,
                    Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                },
                new Album
                {
                    Id = 4,
                    Name = "Gönül Sayfam",
                    Artist = "Kayahan",
                    ReleaseDate = new DateOnly(2000, 01, 01),
                    Price = 975,
                    Discount = 0,
                    Status = true,
                    Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                },
                 new Album
                 {
                     Id = 5,
                     Name = "Akustik Travma",
                     Artist = "Yüzyüzeyken Konuşuruz",
                     ReleaseDate = new DateOnly(2018, 01, 01),
                     Price = 975,
                     Discount = 0,
                     Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286)
                 });

        }
        // Serverler için kısa yol yapılır.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string serverMinel = "DESKTOP-J5485VO";
            string serverEfnan = "DESKTOP-VAQBE6U";
            string serverMustafa = "DESKTOP-U76CSFK";

            string connStr = $"Server={serverMinel};Database=AYS_DB;Trusted_Connection=true;Trustservercertificate=true";

            optionsBuilder.UseSqlServer(connStr);
        }

    }
}
