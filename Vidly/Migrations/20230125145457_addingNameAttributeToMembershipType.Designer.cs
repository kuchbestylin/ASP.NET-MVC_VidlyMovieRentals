﻿// <auto-generated />
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
    [Migration("20230125145457_addingNameAttributeToMembershipType")]
    partial class addingNameAttributeToMembershipType
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
