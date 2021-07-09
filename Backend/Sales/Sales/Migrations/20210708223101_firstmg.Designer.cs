﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales;

namespace Sales.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20210708223101_firstmg")]
    partial class firstmg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategoryItem", b =>
                {
                    b.Property<int>("CategoriesCategory_ID")
                        .HasColumnType("int");

                    b.Property<int>("ItemsItem_ID")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategory_ID", "ItemsItem_ID");

                    b.HasIndex("ItemsItem_ID");

                    b.ToTable("CategoryItem");
                });

            modelBuilder.Entity("InvoiceItem", b =>
                {
                    b.Property<int>("InvoicesInvoice_ID")
                        .HasColumnType("int");

                    b.Property<int>("ItemsItem_ID")
                        .HasColumnType("int");

                    b.HasKey("InvoicesInvoice_ID", "ItemsItem_ID");

                    b.HasIndex("ItemsItem_ID");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("Sales.Models.Category", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Sales.Models.Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_Num")
                        .HasColumnType("int");

                    b.HasKey("Customer_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Sales.Models.Invoice", b =>
                {
                    b.Property<int>("Invoice_ID")
                        .HasColumnType("int");

                    b.Property<int>("CX_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Invoice_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Invoice_ID");

                    b.HasIndex("CX_ID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Sales.Models.Invoice_Details", b =>
                {
                    b.Property<int>("Item_ID")
                        .HasColumnType("int");

                    b.Property<int>("Invoice_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("Total_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Total_Quantity")
                        .HasColumnType("int");

                    b.HasKey("Item_ID", "Invoice_ID");

                    b.ToTable("Invoice_Details");
                });

            modelBuilder.Entity("Sales.Models.Item", b =>
                {
                    b.Property<int>("Item_ID")
                        .HasColumnType("int");

                    b.Property<string>("Item_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Production_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Stock")
                        .HasColumnType("bit");

                    b.Property<decimal>("Unit_Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Item_ID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Sales.Models.Items_Categories", b =>
                {
                    b.Property<int>("Item_ID")
                        .HasColumnType("int");

                    b.Property<int>("Category_ID")
                        .HasColumnType("int");

                    b.HasKey("Item_ID", "Category_ID");

                    b.ToTable("Items_Categories");
                });

            modelBuilder.Entity("CategoryItem", b =>
                {
                    b.HasOne("Sales.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategory_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sales.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsItem_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvoiceItem", b =>
                {
                    b.HasOne("Sales.Models.Invoice", null)
                        .WithMany()
                        .HasForeignKey("InvoicesInvoice_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sales.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsItem_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sales.Models.Invoice", b =>
                {
                    b.HasOne("Sales.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CX_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Sales.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });
#pragma warning restore 612, 618
        }
    }
}
