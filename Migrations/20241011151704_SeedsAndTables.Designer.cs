﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaGestionPedidos.Data;

#nullable disable

namespace SistemaGestionPedidos.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241011151704_SeedsAndTables")]
    partial class SeedsAndTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("SistemaGestionPedidos.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Bebidas frías y calientes",
                            Name = "Bebidas"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dulces y postres variados",
                            Name = "Postres"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Aperitivos y entradas ligeras",
                            Name = "Entradas"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Ensaladas frescas y saludables",
                            Name = "Ensaladas"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Variedad de pastas italianas",
                            Name = "Pastas"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Platos a base de carne",
                            Name = "Carnes"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Platos de mariscos frescos",
                            Name = "Pescados y Mariscos"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Opciones vegetarianas y veganas",
                            Name = "Vegetariano"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Hamburguesas, pizzas y más",
                            Name = "Comida Rápida"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Sopas y caldos variados",
                            Name = "Sopas"
                        });
                });

            modelBuilder.Entity("SistemaGestionPedidos.Models.Entitys.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Café negro caliente",
                            Name = "Café",
                            Price = 2.50m,
                            Quantity = 100m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 9,
                            Description = "Hamburguesa clásica con queso",
                            Name = "Hamburguesa",
                            Price = 8.99m,
                            Quantity = 50m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            Description = "Ensalada fresca con aderezo César",
                            Name = "Ensalada César",
                            Price = 6.50m,
                            Quantity = 30m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 9,
                            Description = "Pizza tradicional italiana",
                            Name = "Pizza Margherita",
                            Price = 12.00m,
                            Quantity = 25m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Tarta de manzana casera",
                            Name = "Tarta de Manzana",
                            Price = 4.00m,
                            Quantity = 40m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 5,
                            Description = "Pasta con salsa Alfredo y pollo",
                            Name = "Pasta Alfredo",
                            Price = 9.75m,
                            Quantity = 20m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            Description = "Salmón fresco a la parrilla",
                            Name = "Filete de Salmón",
                            Price = 15.99m,
                            Quantity = 15m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 10,
                            Description = "Sopa caliente de tomate",
                            Name = "Sopa de Tomate",
                            Price = 3.25m,
                            Quantity = 35m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 8,
                            Description = "Sandwich de vegetales frescos",
                            Name = "Sandwich Vegetariano",
                            Price = 5.50m,
                            Quantity = 45m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "Jugo natural de naranja",
                            Name = "Jugo de Naranja",
                            Price = 2.00m,
                            Quantity = 60m
                        });
                });

            modelBuilder.Entity("SistemaGestionPedidos.Models.Entitys.Product", b =>
                {
                    b.HasOne("SistemaGestionPedidos.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
