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

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string serverMinel = "DESKTOP-J5485VO";
            string serverEfnan = "DESKTOP-VAQBE6U";

            string connStr = $"Server={serverMinel};Database=AYS_DB;Trusted_Connection=true;Trustservercertificate=true";

            optionsBuilder.UseSqlServer(connStr);
        }

    }
}
