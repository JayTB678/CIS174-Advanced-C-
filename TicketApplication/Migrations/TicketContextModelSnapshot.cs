﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketApplication.Models;

#nullable disable

namespace TicketApplication.Migrations
{
    [DbContext(typeof(TicketContext))]
    partial class TicketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketApplication.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointValue")
                        .HasColumnType("int");

                    b.Property<int>("SprintNumber")
                        .HasColumnType("int");

                    b.Property<int>("TicketStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketStatusId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Create a new project in Visual Studio",
                            Name = "Create a new project",
                            PointValue = 3,
                            SprintNumber = 1,
                            TicketStatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Add a new model to the project",
                            Name = "Add a new model",
                            PointValue = 5,
                            SprintNumber = 1,
                            TicketStatusId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Create a new controller in the project",
                            Name = "Create a new controller",
                            PointValue = 8,
                            SprintNumber = 1,
                            TicketStatusId = 3
                        });
                });

            modelBuilder.Entity("TicketApplication.Models.TicketStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TicketStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "To Do"
                        },
                        new
                        {
                            Id = 2,
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Done"
                        },
                        new
                        {
                            Id = 4,
                            Name = "QA"
                        });
                });

            modelBuilder.Entity("TicketApplication.Models.Ticket", b =>
                {
                    b.HasOne("TicketApplication.Models.TicketStatus", "Status")
                        .WithMany()
                        .HasForeignKey("TicketStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
