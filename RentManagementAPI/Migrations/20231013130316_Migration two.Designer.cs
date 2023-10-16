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
    [Migration("20231013130316_Migration two")]
    partial class Migrationtwo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentManagementAPI.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Building");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Deposite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DepositeAmount")
                        .HasColumnType("float");

                    b.Property<double>("DueAmount")
                        .HasColumnType("float");

                    b.Property<int>("RentId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("TranDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Deposite");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Flat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Bedroom")
                        .HasColumnType("int");

                    b.Property<string>("FlatSide")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlatSize")
                        .HasColumnType("int");

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<double>("GasBill")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MasterbedRoom")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RentAmount")
                        .HasColumnType("float");

                    b.Property<double>("ServiceCharge")
                        .HasColumnType("float");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Washroom")
                        .HasColumnType("int");

                    b.Property<double>("WaterBill")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FloorId");

                    b.HasIndex("TenantId");

                    b.ToTable("Flat");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Floor");
                });

            modelBuilder.Entity("RentManagementAPI.Models.IncomeExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IncomeExpenseType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IncomeExpense");
                });

            modelBuilder.Entity("RentManagementAPI.Models.IncomeExpenseTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("IncomeExpenseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TranDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IncomeExpenseTransaction");
                });

            modelBuilder.Entity("RentManagementAPI.Models.PropertyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyInfo");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DueAmount")
                        .HasColumnType("float");

                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<double>("GasBill")
                        .HasColumnType("float");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrinted")
                        .HasColumnType("bit");

                    b.Property<string>("ReciptNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RentAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("RentMonth")
                        .HasColumnType("datetime2");

                    b.Property<double>("ServiceCharge")
                        .HasColumnType("float");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("WaterBill")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FlatId");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AdvanceAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthCertificateNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmgMobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

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

                    b.Property<DateTime>("RentAmountChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("TenantImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("TenantNidImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("RentManagementAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRegularUser")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Flat", b =>
                {
                    b.HasOne("RentManagementAPI.Models.Floor", "Floor")
                        .WithMany("Flats")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentManagementAPI.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Floor", b =>
                {
                    b.HasOne("RentManagementAPI.Models.Building", null)
                        .WithMany("Floors")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentManagementAPI.Models.Rent", b =>
                {
                    b.HasOne("RentManagementAPI.Models.Flat", "Flat")
                        .WithMany()
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flat");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Building", b =>
                {
                    b.Navigation("Floors");
                });

            modelBuilder.Entity("RentManagementAPI.Models.Floor", b =>
                {
                    b.Navigation("Flats");
                });
#pragma warning restore 612, 618
        }
    }
}
