﻿// <auto-generated />
using ContactsMultiPage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactsMultiPage.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20250129205801_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContactsMultiPage.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Address = "123 Live Ave",
                            Name = "Fake Dad",
                            Note = "Not my real dad.",
                            Phone = "525-180-0000"
                        },
                        new
                        {
                            ContactId = 2,
                            Address = "1234 Diggity Dr",
                            Name = "Fake Mom",
                            Note = "Best fake mom ever!",
                            Phone = "555-123-4567"
                        },
                        new
                        {
                            ContactId = 3,
                            Address = "1254 Espresso St",
                            Name = "John Smith",
                            Note = "Work partner/Team project lead.",
                            Phone = "525-555-4444"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
