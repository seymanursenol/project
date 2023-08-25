﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerWApp.Models;

#nullable disable

namespace ServerWApp.Migrations
{
    [DbContext(typeof(FoodContext))]
    [Migration("20230822094108_TableUpdateProducts")]
    partial class TableUpdateProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServerWApp.Models.Kitchen", b =>
                {
                    b.Property<int>("KitchenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitchenId"));

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitchenAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KitchenId");

                    b.ToTable("Kitchens");
                });

            modelBuilder.Entity("ServerWApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RestorantId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("RestorantId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ServerWApp.Models.Restorant", b =>
                {
                    b.Property<int>("RestorantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestorantId"));

                    b.Property<string>("Dakika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitchenId")
                        .HasColumnType("int");

                    b.Property<string>("KitchenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestSahibiEMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestSahibiFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestSahibiPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestorantAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestorantEMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestorantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestorantId");

                    b.HasIndex("KitchenId");

                    b.ToTable("Restorants");
                });

            modelBuilder.Entity("ServerWApp.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ServerWApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ServerWApp.Models.Product", b =>
                {
                    b.HasOne("ServerWApp.Models.Restorant", "Restorant")
                        .WithMany()
                        .HasForeignKey("RestorantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restorant");
                });

            modelBuilder.Entity("ServerWApp.Models.Restorant", b =>
                {
                    b.HasOne("ServerWApp.Models.Kitchen", "Kitchen")
                        .WithMany()
                        .HasForeignKey("KitchenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitchen");
                });
#pragma warning restore 612, 618
        }
    }
}
