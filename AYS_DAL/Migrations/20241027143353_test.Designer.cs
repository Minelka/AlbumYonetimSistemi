﻿// <auto-generated />
using System;
using AYS_DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AYS_DAL.Migrations
{
    [DbContext(typeof(DB_AYSContext))]
    [Migration("20241027143353_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AYS_DAL.Entities.Concrete.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286),
                            IsActive = false,
                            Name = "Göksel",
                            Password = "password123"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286),
                            IsActive = false,
                            Name = "Minel",
                            Password = "password123"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286),
                            IsActive = false,
                            Name = "Efnan",
                            Password = "password123"
                        });
                });

            modelBuilder.Entity("AYS_DAL.Entities.Concrete.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Serdar Ortaç",
                            Created = new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286),
                            Discount = 0m,
                            IsActive = false,
                            Name = "Mesafe",
                            Price = 55m,
                            ReleaseDate = new DateOnly(2006, 1, 5),
                            Status = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
