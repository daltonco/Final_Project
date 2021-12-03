﻿// <auto-generated />
using Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Project.Migrations
{
    [DbContext(typeof(SportsTeamsContext))]
    [Migration("20211203013323_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Final_Project.Models.Teams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("League")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Titles")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BestTeams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "England",
                            League = "Premier League",
                            Name = "Arsenal FC",
                            Sport = "Soccer",
                            Titles = 3
                        },
                        new
                        {
                            Id = 2,
                            Country = "USA",
                            League = "NFL",
                            Name = "Bengals",
                            Sport = "Football",
                            Titles = 0
                        },
                        new
                        {
                            Id = 3,
                            Country = "USA",
                            League = "NFL",
                            Name = "Browns",
                            Sport = "Football",
                            Titles = 4
                        },
                        new
                        {
                            Id = 4,
                            Country = "USA",
                            League = "MLB",
                            Name = "Reds",
                            Sport = "Baseball",
                            Titles = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
