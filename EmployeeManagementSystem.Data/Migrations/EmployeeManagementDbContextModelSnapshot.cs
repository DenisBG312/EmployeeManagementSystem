﻿// <auto-generated />
using System;
using EmployeeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagementSystem.Data.Migrations
{
    [DbContext(typeof(EmployeeManagementDbContext))]
    partial class EmployeeManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeManagementSystem.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfHire")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1990, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2015, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "555-234-5678",
                            Role = 5
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1982, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2008, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Michael",
                            LastName = "Johnson",
                            PhoneNumber = "555-345-6789",
                            Role = 1
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1993, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2017, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emily",
                            LastName = "Davis",
                            PhoneNumber = "555-456-7890",
                            Role = 3
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1978, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2003, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Christopher",
                            LastName = "Lee",
                            PhoneNumber = "555-567-8901",
                            Role = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
