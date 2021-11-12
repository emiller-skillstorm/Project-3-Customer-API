﻿// <auto-generated />
using System;
using CustomerTestAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerTestAPI.Data.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20211112205006_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerTestAPI.Domain.Address", b =>
                {
                    b.Property<int>("Address_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Address_ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CustomerTestAPI.Domain.Coordinates", b =>
                {
                    b.Property<int>("Coordinate_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Long")
                        .HasColumnType("float");

                    b.HasKey("Coordinate_ID");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("CustomerTestAPI.Domain.Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Address_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Coordinate_ID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_ID");

                    b.HasIndex("Address_ID");

                    b.HasIndex("Coordinate_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CustomerTestAPI.Domain.Customer", b =>
                {
                    b.HasOne("CustomerTestAPI.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("Address_ID");

                    b.HasOne("CustomerTestAPI.Domain.Coordinates", "Coord")
                        .WithMany()
                        .HasForeignKey("Coordinate_ID");

                    b.Navigation("Address");

                    b.Navigation("Coord");
                });
#pragma warning restore 612, 618
        }
    }
}
