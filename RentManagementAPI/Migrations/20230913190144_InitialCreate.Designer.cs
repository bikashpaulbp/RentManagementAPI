﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentManagementAPI.Data;

#nullable disable

namespace RentManagementAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230913190144_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentManagementAPI.Models.Deposite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DepositeAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("DepositeDatet")
                        .HasColumnType("datetime2");

                    b.Property<double>("DueAmount")
                        .HasColumnType("float");

                    b.Property<int>("RentId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("RentId");

                    b.ToTable("Deposite");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Flat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FlatSide")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlatSize")
                        .HasColumnType("int");

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<int>("MasterbedRoom")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FloorId");

                    b.ToTable("Flat");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Floor");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RentMonth")
                        .HasColumnType("datetime2");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FlatId");

                    b.HasIndex("TenantId");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthCertificateNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ElectricityBill")
                        .HasColumnType("float");

                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<double>("GasBill")
                        .HasColumnType("float");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoofFamilyMember")
                        .HasColumnType("int");

                    b.Property<string>("PassportNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RentAmount")
                        .HasColumnType("float");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<double>("WaterBill")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FlatId")
                        .IsUnique();

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Deposite", b =>
                {
                    b.HasOne("RentManagementAPI.Models.Rent", "Rent")
                        .WithMany("Deposites")
                        .HasForeignKey("RentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rent");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Flat", b =>
                {
                    b.HasOne("RentManagementAPI.Models.Floor", "Floor")
                        .WithMany("Flats")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Rent", b =>
                {
                    b.HasOne("RentManagementAPI.Models.Flat", "Flat")
                        .WithMany()
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentManagementAPI.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flat");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Tenant", b =>
                {
                    b.HasOne("RentManagementAPI.Models.Flat", "Flat")
                        .WithOne("Tenant")
                        .HasForeignKey("RentManagementAPI.Models.Tenant", "FlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flat");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Flat", b =>
                {
                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Floor", b =>
                {
                    b.Navigation("Flats");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Rent", b =>
                {
                    b.Navigation("Deposites");
                });
#pragma warning restore 612, 618
        }
    }
}
