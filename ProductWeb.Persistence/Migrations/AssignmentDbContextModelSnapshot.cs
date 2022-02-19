﻿// <auto-generated />
using System;
using ProductWeb.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProductWeb.Persistence.Migrations
{
    [DbContext(typeof(AssignmentDbContext))]
    partial class AssignmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProductWeb.Domain.Entity.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Picture")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "b1b20620-03d4-49c4-afdc-56784be97662",
                            Code = "85a9c65e",
                            Name = "Product_1",
                            Picture = "http://www.example.com/998e3607",
                            Price = 31.77m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8060)
                        },
                        new
                        {
                            Id = "e758f9d0-350c-4c74-beac-5e96df2f2e93",
                            Code = "ac1d7fd6",
                            Name = "Product_2",
                            Picture = "http://www.example.com/02093973",
                            Price = 33.33m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8087)
                        },
                        new
                        {
                            Id = "7d0b2685-a147-4d0a-b14b-1686c2f8fd28",
                            Code = "7c3325a6",
                            Name = "Product_3",
                            Picture = "http://www.example.com/60f88fd1",
                            Price = 45.61m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8107)
                        },
                        new
                        {
                            Id = "542ca218-e9f1-4841-9208-4484d8069bc3",
                            Code = "6a37d6f1",
                            Name = "Product_4",
                            Picture = "http://www.example.com/156c57e5",
                            Price = 59.38m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8163)
                        },
                        new
                        {
                            Id = "09214502-f387-49a9-befc-6b6dc51fea96",
                            Code = "e540fb54",
                            Name = "Product_5",
                            Picture = "http://www.example.com/96ba5381",
                            Price = 3.62m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8185)
                        },
                        new
                        {
                            Id = "1d5d92c6-50e1-45f3-93e5-fb27ed2cd18f",
                            Code = "ee0b29c5",
                            Name = "Product_6",
                            Picture = "http://www.example.com/08f9463d",
                            Price = 12.22m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8208)
                        },
                        new
                        {
                            Id = "06a0ec8e-8f2d-476d-aeb5-e67474118d61",
                            Code = "5a42842e",
                            Name = "Product_7",
                            Picture = "http://www.example.com/56fc6ac6",
                            Price = 38.59m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8229)
                        },
                        new
                        {
                            Id = "9756f5b6-bdfd-41fb-b71d-bedac3bb761a",
                            Code = "ff33806c",
                            Name = "Product_8",
                            Picture = "http://www.example.com/57c97deb",
                            Price = 20.02m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8248)
                        },
                        new
                        {
                            Id = "e384f667-57e2-43c8-b23f-fef2c90dc139",
                            Code = "a62b24ea",
                            Name = "Product_9",
                            Picture = "http://www.example.com/951289be",
                            Price = 0.11m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8269)
                        },
                        new
                        {
                            Id = "e66efbb1-4178-4b46-93c7-008e04d48197",
                            Code = "ef16c957",
                            Name = "Product_10",
                            Picture = "http://www.example.com/1dc713ac",
                            Price = 24.77m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8315)
                        },
                        new
                        {
                            Id = "687cdd4a-5d83-48f4-aa16-508672cb9d56",
                            Code = "13154ea8",
                            Name = "Product_11",
                            Picture = "http://www.example.com/d57f1776",
                            Price = 17.24m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8336)
                        },
                        new
                        {
                            Id = "87b533f6-0118-4180-8009-87bd83ae9d93",
                            Code = "c58f42b6",
                            Name = "Product_12",
                            Picture = "http://www.example.com/1d7e7dd7",
                            Price = 11.71m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8355)
                        },
                        new
                        {
                            Id = "b6119ec1-590f-40d9-8010-0ace2d115769",
                            Code = "308be083",
                            Name = "Product_13",
                            Picture = "http://www.example.com/8cae7eee",
                            Price = 49.37m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8374)
                        },
                        new
                        {
                            Id = "f940d0d4-4bca-4dea-af39-e8645b49a78e",
                            Code = "86e29b7e",
                            Name = "Product_14",
                            Picture = "http://www.example.com/cf73317b",
                            Price = 21.03m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8394)
                        },
                        new
                        {
                            Id = "e09f5732-7c1d-4eb4-a708-eaf8e3f2c09f",
                            Code = "07fdec6c",
                            Name = "Product_15",
                            Picture = "http://www.example.com/42b0c879",
                            Price = 38.90m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8412)
                        },
                        new
                        {
                            Id = "8b3cc4e6-dfb5-47c8-83d6-4f49b65b605c",
                            Code = "b2da035d",
                            Name = "Product_16",
                            Picture = "http://www.example.com/1ed53967",
                            Price = 39.87m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8472)
                        },
                        new
                        {
                            Id = "fa8e4da2-e777-4897-9a3b-acde9f4b92bf",
                            Code = "49c58b06",
                            Name = "Product_17",
                            Picture = "http://www.example.com/57b73960",
                            Price = 12.69m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8494)
                        },
                        new
                        {
                            Id = "0c04d3f6-0d2e-4636-b90c-cf4daff88982",
                            Code = "3f23f691",
                            Name = "Product_18",
                            Picture = "http://www.example.com/2e189850",
                            Price = 63.08m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8514)
                        },
                        new
                        {
                            Id = "c8396d60-10c5-4e0b-8bd7-4bb9a0115603",
                            Code = "2c4b7840",
                            Name = "Product_19",
                            Picture = "http://www.example.com/6928776a",
                            Price = 13.88m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8533)
                        },
                        new
                        {
                            Id = "d34d454c-973f-4eed-8e4c-ed4b0d8aed9d",
                            Code = "9ffd87ba",
                            Name = "Product_20",
                            Picture = "http://www.example.com/f3e2c678",
                            Price = 3.91m,
                            UpdatedAt = new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8553)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}