﻿// <auto-generated />
using CitiesInfo.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitiesInfo.API.Migrations
{
    [DbContext(typeof(CityInfoDbContext))]
    [Migration("20230702143154_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("CitiesInfo.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Homeland",
                            Name = "Bamenda"
                        },
                        new
                        {
                            Id = 2,
                            Description = "South West",
                            Name = "Buea"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Economic Capital",
                            Name = "Douala"
                        });
                });

            modelBuilder.Entity("CitiesInfo.API.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfinterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "The Main street",
                            Name = "Nkwen"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "The Yaounde of Bamenda",
                            Name = "UpStation"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Description = "The University of Bambili",
                            Name = "Bambili"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "The central town of Buea",
                            Name = "Moya"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Description = "The Yaounde of Buea",
                            Name = "Molyko"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            Description = "The market",
                            Name = "UpStation"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 3,
                            Description = "The sea port",
                            Name = "Bonas"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 3,
                            Description = "The police headquarters",
                            Name = "Bonamosadi"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            Description = "The Anglophone area of douala",
                            Name = "Bonaberi"
                        });
                });

            modelBuilder.Entity("CitiesInfo.API.Entities.PointOfInterest", b =>
                {
                    b.HasOne("CitiesInfo.API.Entities.City", "City")
                        .WithMany("PointOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CitiesInfo.API.Entities.City", b =>
                {
                    b.Navigation("PointOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}