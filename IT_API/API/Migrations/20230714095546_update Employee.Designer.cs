﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(FullStackDbContext))]
    [Migration("20230714095546_update Employee")]
    partial class updateEmployee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.model.Customer", b =>
                {
                    b.Property<Guid>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cid");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("API.model.Employee", b =>
                {
                    b.Property<Guid>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.Property<string>("telPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Eid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("API.model.Product", b =>
                {
                    b.Property<Guid>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("API.model.Sales", b =>
                {
                    b.Property<Guid>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("customerTelPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("saleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("totalAmount")
                        .HasColumnType("int");

                    b.Property<int>("totalPrice")
                        .HasColumnType("int");

                    b.HasKey("Sid");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("API.model.onApprove", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pid1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pid2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<string>("gen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Approves");
                });

            modelBuilder.Entity("API.model.salesDetail", b =>
                {
                    b.Property<Guid>("SDid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("eachAmount")
                        .HasColumnType("int");

                    b.Property<string>("proudctId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("saleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("totalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SDid");

                    b.ToTable("saleDetails");
                });

            modelBuilder.Entity("API.model.testMixProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<string>("gen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("testMixProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
