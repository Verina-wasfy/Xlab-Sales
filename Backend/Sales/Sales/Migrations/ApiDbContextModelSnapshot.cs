﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales;

namespace Sales.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Sales.Models.Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<string>("FName")
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

                    b.Property<double>("Total_Price")
                        .HasColumnType("float");

                    b.Property<int>("Total_Quantity")
                        .HasColumnType("int");

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

                    b.Property<double>("TPrice_PerTotalItems")
                        .HasColumnType("float");

                    b.Property<int>("TQuantity_PerItem")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("Item_ID", "Invoice_ID");

                    b.ToTable("Invoice_Details");
                });

            modelBuilder.Entity("Sales.Models.Item", b =>
                {
                    b.Property<int>("Item_ID")
                        .HasColumnType("int");

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Production_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Stock")
                        .HasColumnType("bit");

                    b.Property<double>("Unit_Price")
                        .HasColumnType("float");

                    b.HasKey("Item_ID");

                    b.ToTable("Items");
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
