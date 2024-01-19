﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordsManagement.Models;

#nullable disable

namespace RecordsManagement.Migrations
{
    [DbContext(typeof(RecordContext))]
    partial class RecordContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("RecordsManagement.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "1",
                            Name = "Clothing"
                        },
                        new
                        {
                            CategoryId = "2",
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = "3",
                            Name = "Food and Grocery"
                        },
                        new
                        {
                            CategoryId = "4",
                            Name = "Home and Garden"
                        });
                });

            modelBuilder.Entity("RecordsManagement.Models.Record", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vendor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("WarehouseId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RecordId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("RecordsManagement.Models.Warehouse", b =>
                {
                    b.Property<string>("WarehouseId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            WarehouseId = "1",
                            Name = "Chicago"
                        },
                        new
                        {
                            WarehouseId = "2",
                            Name = "New York"
                        },
                        new
                        {
                            WarehouseId = "3",
                            Name = "San Francisco"
                        },
                        new
                        {
                            WarehouseId = "4",
                            Name = "Miami"
                        });
                });

            modelBuilder.Entity("RecordsManagement.Models.Record", b =>
                {
                    b.HasOne("RecordsManagement.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecordsManagement.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Warehouse");
                });
#pragma warning restore 612, 618
        }
    }
}
