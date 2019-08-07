﻿// <auto-generated />
using CS321_W3D1_BookAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CS321_W3D1_BookAPI.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20190807182005_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("CS321_W3D1_BookAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Category");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Virginia Woolf",
                            Category = "novel",
                            Title = "To The Lighthouse"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Wills Cather",
                            Category = "Novel",
                            Title = "Death Comes To The ArchBishop"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Shel Silverstein",
                            Category = "Children's Literature",
                            Title = "Lafcadio, the Lion Who Shot Back"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}