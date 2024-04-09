﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240409114046_seedData")]
    partial class seedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Catagory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Catagory = "Category 1",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6148),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6134),
                            Description = "Description 1",
                            IsDeleted = false,
                            ItemName = "Item 1",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6149)
                        },
                        new
                        {
                            Id = 2,
                            Catagory = "Category 2",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6158),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6154),
                            Description = "Description 2",
                            IsDeleted = false,
                            ItemName = "Item 2",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6159)
                        },
                        new
                        {
                            Id = 3,
                            Catagory = "Category 3",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6164),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6160),
                            Description = "Description 3",
                            IsDeleted = false,
                            ItemName = "Item 3",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6165)
                        },
                        new
                        {
                            Id = 4,
                            Catagory = "Category 4",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6170),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6166),
                            Description = "Description 4",
                            IsDeleted = false,
                            ItemName = "Item 4",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6171)
                        },
                        new
                        {
                            Id = 5,
                            Catagory = "Category 5",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6176),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6172),
                            Description = "Description 5",
                            IsDeleted = false,
                            ItemName = "Item 5",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6177)
                        },
                        new
                        {
                            Id = 6,
                            Catagory = "Category 6",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6184),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6180),
                            Description = "Description 6",
                            IsDeleted = false,
                            ItemName = "Item 6",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6184)
                        },
                        new
                        {
                            Id = 7,
                            Catagory = "Category 7",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6190),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6186),
                            Description = "Description 7",
                            IsDeleted = false,
                            ItemName = "Item 7",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6190)
                        },
                        new
                        {
                            Id = 8,
                            Catagory = "Category 8",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6197),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6192),
                            Description = "Description 8",
                            IsDeleted = false,
                            ItemName = "Item 8",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6197)
                        },
                        new
                        {
                            Id = 9,
                            Catagory = "Category 9",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6203),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6199),
                            Description = "Description 9",
                            IsDeleted = false,
                            ItemName = "Item 9",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6203)
                        },
                        new
                        {
                            Id = 10,
                            Catagory = "Category 10",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6211),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6206),
                            Description = "Description 10",
                            IsDeleted = false,
                            ItemName = "Item 10",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6212)
                        });
                });

            modelBuilder.Entity("DAL.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("StoreLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactInformation = "Contact Info 1",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5769),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5721),
                            IsDeleted = false,
                            StoreLocation = "Location 1",
                            StoreName = "Store 1",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5770)
                        },
                        new
                        {
                            Id = 2,
                            ContactInformation = "Contact Info 2",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5779),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5775),
                            IsDeleted = false,
                            StoreLocation = "Location 2",
                            StoreName = "Store 2",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5780)
                        },
                        new
                        {
                            Id = 3,
                            ContactInformation = "Contact Info 3",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5786),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5782),
                            IsDeleted = false,
                            StoreLocation = "Location 3",
                            StoreName = "Store 3",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5786)
                        },
                        new
                        {
                            Id = 4,
                            ContactInformation = "Contact Info 4",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5792),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5788),
                            IsDeleted = false,
                            StoreLocation = "Location 4",
                            StoreName = "Store 4",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5793)
                        },
                        new
                        {
                            Id = 5,
                            ContactInformation = "Contact Info 5",
                            CreatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5798),
                            DeletedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5795),
                            IsDeleted = false,
                            StoreLocation = "Location 5",
                            StoreName = "Store 5",
                            UpdatedDate = new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5799)
                        });
                });

            modelBuilder.Entity("DAL.StoreItem", b =>
                {
                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("StoreId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("StoreItems");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            ItemId = 1,
                            Price = 27.65m,
                            Quantity = 97
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 2,
                            Price = 43.94m,
                            Quantity = 49
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 3,
                            Price = 8.20m,
                            Quantity = 51
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 4,
                            Price = 9.01m,
                            Quantity = 9
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 5,
                            Price = 53.82m,
                            Quantity = 10
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 6,
                            Price = 46.59m,
                            Quantity = 55
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 7,
                            Price = 52.36m,
                            Quantity = 76
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 8,
                            Price = 33.19m,
                            Quantity = 72
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 9,
                            Price = 70.33m,
                            Quantity = 90
                        },
                        new
                        {
                            StoreId = 1,
                            ItemId = 10,
                            Price = 34.59m,
                            Quantity = 53
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 1,
                            Price = 24.16m,
                            Quantity = 49
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 2,
                            Price = 59.25m,
                            Quantity = 2
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 3,
                            Price = 47.24m,
                            Quantity = 87
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 4,
                            Price = 56.65m,
                            Quantity = 37
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 5,
                            Price = 86.20m,
                            Quantity = 63
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 6,
                            Price = 27.09m,
                            Quantity = 88
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 7,
                            Price = 79.51m,
                            Quantity = 86
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 8,
                            Price = 21.00m,
                            Quantity = 53
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 9,
                            Price = 25.15m,
                            Quantity = 71
                        },
                        new
                        {
                            StoreId = 2,
                            ItemId = 10,
                            Price = 97.80m,
                            Quantity = 59
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 1,
                            Price = 43.57m,
                            Quantity = 91
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 2,
                            Price = 50.97m,
                            Quantity = 88
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 3,
                            Price = 44.11m,
                            Quantity = 67
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 4,
                            Price = 75.73m,
                            Quantity = 81
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 5,
                            Price = 58.53m,
                            Quantity = 85
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 6,
                            Price = 5.94m,
                            Quantity = 94
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 7,
                            Price = 90.46m,
                            Quantity = 77
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 8,
                            Price = 7.90m,
                            Quantity = 18
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 9,
                            Price = 91.98m,
                            Quantity = 90
                        },
                        new
                        {
                            StoreId = 3,
                            ItemId = 10,
                            Price = 41.06m,
                            Quantity = 43
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 1,
                            Price = 10.39m,
                            Quantity = 69
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 2,
                            Price = 46.56m,
                            Quantity = 70
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 3,
                            Price = 82.93m,
                            Quantity = 75
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 4,
                            Price = 44.62m,
                            Quantity = 95
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 5,
                            Price = 78.26m,
                            Quantity = 7
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 6,
                            Price = 66.61m,
                            Quantity = 11
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 7,
                            Price = 22.95m,
                            Quantity = 74
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 8,
                            Price = 65.27m,
                            Quantity = 51
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 9,
                            Price = 40.32m,
                            Quantity = 13
                        },
                        new
                        {
                            StoreId = 4,
                            ItemId = 10,
                            Price = 12.99m,
                            Quantity = 44
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 1,
                            Price = 91.59m,
                            Quantity = 80
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 2,
                            Price = 87.87m,
                            Quantity = 39
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 3,
                            Price = 97.02m,
                            Quantity = 8
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 4,
                            Price = 15.40m,
                            Quantity = 1
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 5,
                            Price = 66.43m,
                            Quantity = 46
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 6,
                            Price = 35.16m,
                            Quantity = 54
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 7,
                            Price = 39.44m,
                            Quantity = 6
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 8,
                            Price = 72.39m,
                            Quantity = 10
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 9,
                            Price = 82.57m,
                            Quantity = 36
                        },
                        new
                        {
                            StoreId = 5,
                            ItemId = 10,
                            Price = 51.07m,
                            Quantity = 15
                        });
                });

            modelBuilder.Entity("DAL.StoreItem", b =>
                {
                    b.HasOne("DAL.Item", "Item")
                        .WithMany("StoreItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Store", "Store")
                        .WithMany("StoreItems")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("DAL.Item", b =>
                {
                    b.Navigation("StoreItems");
                });

            modelBuilder.Entity("DAL.Store", b =>
                {
                    b.Navigation("StoreItems");
                });
#pragma warning restore 612, 618
        }
    }
}