﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2_03_2023_nevsehir_mvc.Models;

#nullable disable

namespace _2_03_2023_nevsehir_mvc.Migrations
{
    [DbContext(typeof(nevsehirDbContext))]
    [Migration("20230518071845_bes")]
    partial class bes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_2_03_2023_nevsehir_mvc.Models.detayResim", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("detayResimYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sehirId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("detayResim");
                });

            modelBuilder.Entity("_2_03_2023_nevsehir_mvc.Models.gezilecekYerlerTable", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("gYerAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gYerAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gYerResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sehirId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("gezilecekYerlerTable");
                });

            modelBuilder.Entity("_2_03_2023_nevsehir_mvc.Models.sehirTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AltBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SehirAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sehirTable");
                });

            modelBuilder.Entity("_2_03_2023_nevsehir_mvc.Models.sliderTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SliderAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sehirId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("sliderTable");
                });
#pragma warning restore 612, 618
        }
    }
}
