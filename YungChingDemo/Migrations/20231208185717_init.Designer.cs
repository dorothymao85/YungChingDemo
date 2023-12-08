﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YungChingDemo;

#nullable disable

namespace YungChingDemo.Migrations
{
    [DbContext(typeof(YCDBContext))]
    [Migration("20231208185717_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("YungChingDemo.Models.Customers", b =>
                {
                    b.Property<long>("uuid")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("uuid");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("YungChingDemo.Models.Employees", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Extension")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("YungChingDemo.Models.Orders", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Freight")
                        .HasColumnType("money");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipName")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShipVia")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderID");

                    b.ToTable("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
