﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(SportsContext))]
    [Migration("20250306020008_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.OlympicSport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Game")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OlympicSports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Indoor",
                            CountryCode = "ca",
                            Game = "Winter Olympics",
                            Name = "Canada",
                            Sport = "Curling"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Indoor",
                            CountryCode = "se",
                            Game = "Winter Olympics",
                            Name = "Sweden",
                            Sport = "Curling"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Indoor",
                            CountryCode = "gb",
                            Game = "Winter Olympics",
                            Name = "Great Britain",
                            Sport = "Curling"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Outdoor",
                            CountryCode = "jm",
                            Game = "Winter Olympics",
                            Name = "Jamaica",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Outdoor",
                            CountryCode = "it",
                            Game = "Winter Olympics",
                            Name = "Italy",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Outdoor",
                            CountryCode = "jp",
                            Game = "Winter Olympics",
                            Name = "Japan",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Indoor",
                            CountryCode = "de",
                            Game = "Summer Olympics",
                            Name = "Germany",
                            Sport = "Diving"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Indoor",
                            CountryCode = "cn",
                            Game = "Summer Olympics",
                            Name = "China",
                            Sport = "Diving"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Indoor",
                            CountryCode = "mx",
                            Game = "Summer Olympics",
                            Name = "Mexico",
                            Sport = "Diving"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Outdoor",
                            CountryCode = "br",
                            Game = "Summer Olympics",
                            Name = "Brazil",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Outdoor",
                            CountryCode = "nl",
                            Game = "Summer Olympics",
                            Name = "Netherlands",
                            Sport = "Cycling"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Outdoor",
                            CountryCode = "us",
                            Game = "Summer Olympics",
                            Name = "USA",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Indoor",
                            CountryCode = "th",
                            Game = "Paralympics",
                            Name = "Thailand",
                            Sport = "Archery"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Indoor",
                            CountryCode = "uy",
                            Game = "Paralympics",
                            Name = "Uruguay",
                            Sport = "Archery"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Indoor",
                            CountryCode = "ua",
                            Game = "Paralympics",
                            Name = "Ukraine",
                            Sport = "Archery"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Outdoor",
                            CountryCode = "at",
                            Game = "Paralympics",
                            Name = "Austria",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Outdoor",
                            CountryCode = "pk",
                            Game = "Paralympics",
                            Name = "Pakistan",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Outdoor",
                            CountryCode = "zw",
                            Game = "Paralympics",
                            Name = "Zimbabwe",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Indoor",
                            CountryCode = "fr",
                            Game = "Youth Olympic Games",
                            Name = "France",
                            Sport = "Breakdancing"
                        },
                        new
                        {
                            Id = 20,
                            Category = "Indoor",
                            CountryCode = "cy",
                            Game = "Youth Olympic Games",
                            Name = "Cyprus",
                            Sport = "Breakdancing"
                        },
                        new
                        {
                            Id = 21,
                            Category = "Indoor",
                            CountryCode = "ru",
                            Game = "Youth Olympic Games",
                            Name = "Russia",
                            Sport = "Breakdancing"
                        },
                        new
                        {
                            Id = 22,
                            Category = "Outdoor",
                            CountryCode = "fi",
                            Game = "Youth Olympic Games",
                            Name = "Finland",
                            Sport = "Skateboarding"
                        },
                        new
                        {
                            Id = 23,
                            Category = "Outdoor",
                            CountryCode = "sk",
                            Game = "Youth Olympic Games",
                            Name = "Slovakia",
                            Sport = "Skateboarding"
                        },
                        new
                        {
                            Id = 24,
                            Category = "Outdoor",
                            CountryCode = "pt",
                            Game = "Youth Olympic Games",
                            Name = "Portugal",
                            Sport = "Skateboarding"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
