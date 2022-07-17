﻿// <auto-generated />
using System;
using Carpool.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220717133821_CountyMigration")]
    partial class CountyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Carpool.Domain.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CarMakeId")
                        .HasColumnType("integer");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ColorId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("integer");

                    b.Property<string>("Plates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CarMakeId");

                    b.HasIndex("ColorId");

                    b.HasIndex("Plates")
                        .IsUnique();

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("facfdffd-18e3-403e-865b-0a632b3445bc"),
                            CarMakeId = 2,
                            CarModel = "Golf VIII",
                            ColorId = 1,
                            Name = "Milan's Golf",
                            NumberOfSeats = 5,
                            Plates = "BJ-513-DD"
                        },
                        new
                        {
                            Id = new Guid("71af1aab-6795-4750-9fba-a32f7366ca48"),
                            CarMakeId = 9,
                            CarModel = "Mustang",
                            ColorId = 9,
                            Name = "John's Mustang",
                            NumberOfSeats = 3,
                            Plates = "ZG-5220-IG"
                        },
                        new
                        {
                            Id = new Guid("5944affc-502c-4290-9296-77f7af1bf66a"),
                            CarMakeId = 10,
                            CarModel = "V60",
                            ColorId = 3,
                            Name = "Patricia's Volvo",
                            NumberOfSeats = 5,
                            Plates = "DU-555-PP"
                        },
                        new
                        {
                            Id = new Guid("eded84c4-50aa-4105-a7d1-5a74ba65a54d"),
                            CarMakeId = 5,
                            CarModel = "Supra",
                            ColorId = 4,
                            Name = "Josip's Toyota",
                            NumberOfSeats = 3,
                            Plates = "PU-2224-DC"
                        },
                        new
                        {
                            Id = new Guid("48727973-b5db-47d6-8f4a-c19e5e89b9a6"),
                            CarMakeId = 1,
                            CarModel = "Superb",
                            ColorId = 8,
                            Name = "Damir's Skoda",
                            NumberOfSeats = 5,
                            Plates = "ST-555-BD"
                        },
                        new
                        {
                            Id = new Guid("05399302-0bf6-4a1c-a134-bb624f844a46"),
                            CarMakeId = 3,
                            CarModel = "A5",
                            ColorId = 10,
                            Name = "Ivan's Auid",
                            NumberOfSeats = 3,
                            Plates = "PU-333-DB"
                        },
                        new
                        {
                            Id = new Guid("131d447b-5d8d-4b8e-b68c-4f15235087b2"),
                            CarMakeId = 4,
                            CarModel = "Leon",
                            ColorId = 2,
                            Name = "Lana's Seat",
                            NumberOfSeats = 5,
                            Plates = "KC-222-DA"
                        },
                        new
                        {
                            Id = new Guid("23a5f8c3-5981-45e4-b432-7a6e2260c8dc"),
                            CarMakeId = 8,
                            CarModel = "Sandero",
                            ColorId = 3,
                            Name = "Silvija's Dacia",
                            NumberOfSeats = 5,
                            Plates = "NA-221-IA"
                        },
                        new
                        {
                            Id = new Guid("45d3da20-9bc8-4d1e-a71b-0cded82c96b1"),
                            CarMakeId = 6,
                            CarModel = "SX4",
                            ColorId = 6,
                            Name = "Tomislav's Suzuki",
                            NumberOfSeats = 5,
                            Plates = "B-444-AA"
                        },
                        new
                        {
                            Id = new Guid("0fd94679-86f1-4ec5-8569-df6fcb8b8187"),
                            CarMakeId = 7,
                            CarModel = "Captiva",
                            ColorId = 7,
                            Name = "Nebojsa's Chevy",
                            NumberOfSeats = 5,
                            Plates = "RI-6776-DU"
                        });
                });

            modelBuilder.Entity("Carpool.Domain.Entities.CarMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CarMakes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Skoda"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Volkswagen"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Seat"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Suzuki"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dacia"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Volvo"
                        });
                });

            modelBuilder.Entity("Carpool.Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Black"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Blue"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Brown"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gold"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Gray"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Green"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Orange"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Purple"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Red"
                        },
                        new
                        {
                            Id = 10,
                            Name = "White"
                        });
                });

            modelBuilder.Entity("Carpool.Domain.Entities.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Counties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bjelovarsko-bilogorska"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Brodsko-posavska"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dubrovačko-neretvanska"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Istarska"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Karlovacka"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Koprivničko-križevačka"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Krapinsko-zagorska"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ličko-senjska"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Međimurska"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Osječko-baranjska"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Požeško-slavonska"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Primorsko-goranska"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Sisačko-moslavačka"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Splitsko-dalmatinska"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Šibensko-kninska"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Varaždinska"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Virovitičko-podravska"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Vukovarsko-srijemska"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Zadarska"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Zagrebačka"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Grad Zagreb"
                        });
                });

            modelBuilder.Entity("Carpool.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDriver")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id", "EmployeeId")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c2ab8ea1-5a41-4f29-8051-8e46f7965974"),
                            EmployeeId = 1,
                            EmployeeName = "Ivan Kranjec",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("ee10bbef-5161-4f0f-9e82-d24d59f47824"),
                            EmployeeId = 2,
                            EmployeeName = "Damir Rose",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("432febab-0d2e-4e63-abae-e1967e58b712"),
                            EmployeeId = 3,
                            EmployeeName = "Ana Lazaric",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("191f46ef-c14e-424f-99e8-ea79a4c1c18c"),
                            EmployeeId = 4,
                            EmployeeName = "Thomas Horvar",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("cdf06a97-a5bb-46ae-a056-9bfd07ee61f2"),
                            EmployeeId = 5,
                            EmployeeName = "Marko Mlinarić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("78622a1a-7878-4c70-83b8-b1a6fa01748e"),
                            EmployeeId = 6,
                            EmployeeName = "Josip Tandara",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("8aea8956-f3fd-46ea-8597-40b2ebf28199"),
                            EmployeeId = 7,
                            EmployeeName = "Marin Horvat",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("73267d95-de52-4267-8fe2-e5f970e3152c"),
                            EmployeeId = 8,
                            EmployeeName = "Dino Jelusić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("5964d5c1-2e5b-48ad-9bf4-0655f70c0a55"),
                            EmployeeId = 9,
                            EmployeeName = "Miroslav Škoro",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("80139e91-6613-48d0-b20f-67266a96dc28"),
                            EmployeeId = 10,
                            EmployeeName = "Hrvoje Plenk",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("79d4fa81-7ff0-4ba3-bdcc-542a29e144ec"),
                            EmployeeId = 11,
                            EmployeeName = "Matej Dušan",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("04138783-0645-4b0f-8844-b5543b8579b4"),
                            EmployeeId = 12,
                            EmployeeName = "Peter Pan",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("3ea28d9a-6d48-47ab-aa99-5dab4e53d15f"),
                            EmployeeId = 13,
                            EmployeeName = "Hrvoje Mirić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("86ff0900-e49c-45e1-9b3a-94e0a0cc9e04"),
                            EmployeeId = 14,
                            EmployeeName = "Jasna Gruber",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("1c0cc5db-2fcb-47a1-98ad-847b5f246d02"),
                            EmployeeId = 15,
                            EmployeeName = "Mario Budimir",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("ee04f5ea-efed-47b2-b837-c7422ab4a591"),
                            EmployeeId = 16,
                            EmployeeName = "Igor Babić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("ad1efa0d-a2f3-4767-a0d9-dd54bc5a2a23"),
                            EmployeeId = 17,
                            EmployeeName = "Marija Husar",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("d01dd99a-8ffd-43cb-b847-28abab47e2cb"),
                            EmployeeId = 18,
                            EmployeeName = "Melita Huskvarnić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("32f34fd7-5463-4df9-9914-1891792b2c6c"),
                            EmployeeId = 19,
                            EmployeeName = "Lana Jurčević",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("aab57b40-261b-4cdb-813c-70cf639405a5"),
                            EmployeeId = 20,
                            EmployeeName = "Mihaela Dubrovnik",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("f0f1e643-0eac-4548-884c-930cb5347164"),
                            EmployeeId = 21,
                            EmployeeName = "Ivan Ivanović",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("25920735-e3c1-44b9-b111-326fc9398683"),
                            EmployeeId = 22,
                            EmployeeName = "Luka Cvrtila",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("d8a85827-3848-49a3-85ca-ffef9ffe990a"),
                            EmployeeId = 23,
                            EmployeeName = "Dubravko Marček",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("f88deba0-e6bf-4d33-9beb-cfb925e08fcd"),
                            EmployeeId = 24,
                            EmployeeName = "Dubravka Martinić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("aa3a9d2e-5836-44ff-88b6-1266f4f252c7"),
                            EmployeeId = 25,
                            EmployeeName = "Nenad Kovaček",
                            IsDriver = true
                        });
                });

            modelBuilder.Entity("Carpool.Domain.Entities.Car", b =>
                {
                    b.HasOne("Carpool.Domain.Entities.CarMake", "CarMake")
                        .WithMany()
                        .HasForeignKey("CarMakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.Domain.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarMake");

                    b.Navigation("Color");
                });
#pragma warning restore 612, 618
        }
    }
}