﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unit2Project.Models;

#nullable disable

namespace Unit2Project.Migrations
{
    [DbContext(typeof(ComicContext))]
    partial class ComicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Unit2Project.Models.Comic", b =>
                {
                    b.Property<int?>("ComicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ComicId"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IssueNo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComicId");

                    b.ToTable("Comics");

                    b.HasData(
                        new
                        {
                            ComicId = 1,
                            Company = "Marvel",
                            IssueNo = 1,
                            Name = "Absolute Carnage"
                        },
                        new
                        {
                            ComicId = 2,
                            Company = "D.C.",
                            IssueNo = 1,
                            Name = "Batman: Year One"
                        },
                        new
                        {
                            ComicId = 3,
                            Company = "Image Comics",
                            IssueNo = 1,
                            Name = "Invincible"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
