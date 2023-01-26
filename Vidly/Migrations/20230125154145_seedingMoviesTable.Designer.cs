﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vidly.Data;

#nullable disable

namespace Vidly.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230125154145_seedingMoviesTable")]
    partial class seedingMoviesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSubscribedToNewsLetter")
                        .HasColumnType("bit");

                    b.Property<int>("MembershipTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Vidly.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DurationInMonths")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MembershipType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountRate = (byte)0,
                            DurationInMonths = (byte)0,
                            Name = "Free",
                            SignUpFee = (short)0
                        },
                        new
                        {
                            Id = 2,
                            DiscountRate = (byte)10,
                            DurationInMonths = (byte)1,
                            Name = "Basic",
                            SignUpFee = (short)30
                        },
                        new
                        {
                            Id = 3,
                            DiscountRate = (byte)15,
                            DurationInMonths = (byte)3,
                            Name = "Compact",
                            SignUpFee = (short)90
                        },
                        new
                        {
                            Id = 4,
                            DiscountRate = (byte)20,
                            DurationInMonths = (byte)12,
                            Name = "Premium",
                            SignUpFee = (short)300
                        });
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Release")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Romance",
                            Name = "A Perfect Match",
                            Release = new DateTime(2016, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Adventure",
                            Name = "Jumanji",
                            Release = new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Mistery",
                            Name = "A Resonable Doubt",
                            Release = new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Romance",
                            Name = "Brown Coffee",
                            Release = new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 5,
                            Genre = "Thriller",
                            Name = "Most Wanted",
                            Release = new DateTime(2016, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 6,
                            Genre = "Thriller",
                            Name = "The Maze Runner",
                            Release = new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 7,
                            Genre = "Scify",
                            Name = "Blade Runner",
                            Release = new DateTime(2017, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 8,
                            Genre = "Action",
                            Name = "13 Hours the Secret Soldier",
                            Release = new DateTime(2012, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 9,
                            Genre = "Action",
                            Name = "The Matrix Ressurection",
                            Release = new DateTime(1994, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        });
                });

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.HasOne("Vidly.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");
                });
#pragma warning restore 612, 618
        }
    }
}
