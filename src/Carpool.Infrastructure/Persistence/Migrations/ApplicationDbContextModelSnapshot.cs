﻿// <auto-generated />
using System;
using Carpool.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("30ccac74-314e-4f69-abae-465b486b37f9"),
                            CarMakeId = 2,
                            CarModel = "Golf VIII",
                            ColorId = 1,
                            Name = "Milan's Golf",
                            NumberOfSeats = 5,
                            Plates = "BJ-513-DD"
                        },
                        new
                        {
                            Id = new Guid("ed1c4d6e-2512-42ce-86c4-e07bf2991df6"),
                            CarMakeId = 9,
                            CarModel = "Mustang",
                            ColorId = 9,
                            Name = "John's Mustang",
                            NumberOfSeats = 3,
                            Plates = "ZG-5220-IG"
                        },
                        new
                        {
                            Id = new Guid("dc39b9ce-ba3f-4dcd-ad12-be16065b0723"),
                            CarMakeId = 10,
                            CarModel = "V60",
                            ColorId = 3,
                            Name = "Patricia's Volvo",
                            NumberOfSeats = 5,
                            Plates = "DU-555-PP"
                        },
                        new
                        {
                            Id = new Guid("2acd2627-efdb-4ce5-9897-55622d87ff0c"),
                            CarMakeId = 5,
                            CarModel = "Supra",
                            ColorId = 4,
                            Name = "Josip's Toyota",
                            NumberOfSeats = 3,
                            Plates = "PU-2224-DC"
                        },
                        new
                        {
                            Id = new Guid("a0ade0c6-3fee-443e-823d-d7ab33bebcdf"),
                            CarMakeId = 1,
                            CarModel = "Superb",
                            ColorId = 8,
                            Name = "Damir's Skoda",
                            NumberOfSeats = 5,
                            Plates = "ST-555-BD"
                        },
                        new
                        {
                            Id = new Guid("3d78a404-053a-42ee-87fd-18872acffcf5"),
                            CarMakeId = 3,
                            CarModel = "A5",
                            ColorId = 10,
                            Name = "Ivan's Auid",
                            NumberOfSeats = 3,
                            Plates = "PU-333-DB"
                        },
                        new
                        {
                            Id = new Guid("b59f57ea-c6fa-4cb8-99fb-91aaf1bda424"),
                            CarMakeId = 4,
                            CarModel = "Leon",
                            ColorId = 2,
                            Name = "Lana's Seat",
                            NumberOfSeats = 5,
                            Plates = "KC-222-DA"
                        },
                        new
                        {
                            Id = new Guid("5c2a44bc-b78d-41f9-bb78-a1a774f7d160"),
                            CarMakeId = 8,
                            CarModel = "Sandero",
                            ColorId = 3,
                            Name = "Silvija's Dacia",
                            NumberOfSeats = 5,
                            Plates = "NA-221-IA"
                        },
                        new
                        {
                            Id = new Guid("8c9f317a-8e54-4fe8-aba3-2de74816fdd7"),
                            CarMakeId = 6,
                            CarModel = "SX4",
                            ColorId = 6,
                            Name = "Tomislav's Suzuki",
                            NumberOfSeats = 5,
                            Plates = "B-444-AA"
                        },
                        new
                        {
                            Id = new Guid("fbce413a-7714-47f3-8997-adfcdc508306"),
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

            modelBuilder.Entity("Carpool.Domain.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CountyId")
                        .HasColumnType("integer");

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

                    b.HasIndex("CountyId");

                    b.HasIndex("Name", "CountyId")
                        .IsUnique();

                    b.ToTable("Cities");
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
                            Name = "Karlovačka"
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
                            Id = new Guid("12332cd7-a4e0-42ea-bce1-e34ff6d355f0"),
                            EmployeeId = 1,
                            EmployeeName = "Ivan Kranjec",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("41b275ec-3113-4d8d-af64-368532bd8b1f"),
                            EmployeeId = 2,
                            EmployeeName = "Damir Rose",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("5a1f8040-7058-4aeb-8fb8-4f842da147d8"),
                            EmployeeId = 3,
                            EmployeeName = "Ana Lazaric",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("2fa78dec-8e59-418c-9a33-d8a713eec057"),
                            EmployeeId = 4,
                            EmployeeName = "Thomas Horvar",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("1afd2675-40d9-4cf8-b491-c6d2874a4374"),
                            EmployeeId = 5,
                            EmployeeName = "Marko Mlinarić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("5a583697-06ed-40e4-8abb-1d9affb4872a"),
                            EmployeeId = 6,
                            EmployeeName = "Josip Tandara",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("c2291347-ffad-4fb1-9b88-269c5a124c78"),
                            EmployeeId = 7,
                            EmployeeName = "Marin Horvat",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("a08a6108-201e-4726-9164-e70e2331e27f"),
                            EmployeeId = 8,
                            EmployeeName = "Dino Jelusić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("e4ce4bce-b32f-4895-b5d8-bbff3bb18894"),
                            EmployeeId = 9,
                            EmployeeName = "Miroslav Škoro",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("e747c491-96e4-4387-a201-45a29e4dc108"),
                            EmployeeId = 10,
                            EmployeeName = "Hrvoje Plenk",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("01a4b19d-a047-44f1-abdb-2c8e78a36713"),
                            EmployeeId = 11,
                            EmployeeName = "Matej Dušan",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("2af62f73-74a5-4525-a0ae-266dd675be0a"),
                            EmployeeId = 12,
                            EmployeeName = "Peter Pan",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("83b6ecd3-03ad-4685-a305-2a551983fead"),
                            EmployeeId = 13,
                            EmployeeName = "Hrvoje Mirić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("f003fdef-3448-4fad-869f-ec07590852e7"),
                            EmployeeId = 14,
                            EmployeeName = "Jasna Gruber",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("04f2a208-9e6a-408a-9817-26b46d43e76b"),
                            EmployeeId = 15,
                            EmployeeName = "Mario Budimir",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("7a881ff5-a162-435d-935d-6c36cc764196"),
                            EmployeeId = 16,
                            EmployeeName = "Igor Babić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("19febe99-4b17-4cf2-94a1-bc378d6a8fb3"),
                            EmployeeId = 17,
                            EmployeeName = "Marija Husar",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("efbe9f78-b996-4ae6-9279-dfd7cd42fbbb"),
                            EmployeeId = 18,
                            EmployeeName = "Melita Huskvarnić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("4ecdb655-0f12-46fe-93e4-e1af35eae3a4"),
                            EmployeeId = 19,
                            EmployeeName = "Lana Jurčević",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("91c7be9c-c124-46eb-b512-c87b60a1dcac"),
                            EmployeeId = 20,
                            EmployeeName = "Mihaela Dubrovnik",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("05028259-1207-40a1-96d6-5cfa748e9587"),
                            EmployeeId = 21,
                            EmployeeName = "Ivan Ivanović",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("4eabe42a-3d85-4449-a459-971b3d6196a2"),
                            EmployeeId = 22,
                            EmployeeName = "Luka Cvrtila",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("5dc222b3-d33e-4a9e-be1b-5b6e54284c56"),
                            EmployeeId = 23,
                            EmployeeName = "Dubravko Marček",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("9646f036-dab9-4a7f-8f24-f2dfa6f4a0e8"),
                            EmployeeId = 24,
                            EmployeeName = "Dubravka Martinić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("2d4954b4-01ab-46b0-97a8-cfd9021d9e9a"),
                            EmployeeId = 25,
                            EmployeeName = "Nenad Kovaček",
                            IsDriver = true
                        });
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("TravelPlans");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlanEmployee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TravelPlanId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TravelPlanId");

                    b.ToTable("TravelPlanEmployees");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlanEndLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TravelPlanId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("TravelPlanId")
                        .IsUnique();

                    b.ToTable("TravelPlanEndLocations");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlanStartLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TravelPlanId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("TravelPlanId")
                        .IsUnique();

                    b.ToTable("TravelPlanStartLocations");
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

            modelBuilder.Entity("Carpool.Domain.Entities.City", b =>
                {
                    b.HasOne("Carpool.Domain.Entities.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("County");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlan", b =>
                {
                    b.HasOne("Carpool.Domain.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlanEmployee", b =>
                {
                    b.HasOne("Carpool.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.Domain.Entities.TravelPlan", "TravelPlan")
                        .WithMany("TravelPlanEmployees")
                        .HasForeignKey("TravelPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("TravelPlan");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlanEndLocation", b =>
                {
                    b.HasOne("Carpool.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.Domain.Entities.TravelPlan", "TravelPlan")
                        .WithOne("TravelPlanEndLocation")
                        .HasForeignKey("Carpool.Domain.Entities.TravelPlanEndLocation", "TravelPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("TravelPlan");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlanStartLocation", b =>
                {
                    b.HasOne("Carpool.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.Domain.Entities.TravelPlan", "TravelPlan")
                        .WithOne("TravelPlanStartLocation")
                        .HasForeignKey("Carpool.Domain.Entities.TravelPlanStartLocation", "TravelPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("TravelPlan");
                });

            modelBuilder.Entity("Carpool.Domain.Entities.TravelPlan", b =>
                {
                    b.Navigation("TravelPlanEmployees");

                    b.Navigation("TravelPlanEndLocation")
                        .IsRequired();

                    b.Navigation("TravelPlanStartLocation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
