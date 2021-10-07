﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFinlanTechnical.Models;

namespace TFinlanTechnical.Migrations
{
    [DbContext(typeof(FinlanDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("TFinlanTechnical.Models.ToDo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("toDos");
                });
#pragma warning restore 612, 618
        }
    }
}
