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
    [Migration("20220717184155_RunCitiesSeeder")]
    partial class RunCitiesSeeder
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
                            Id = new Guid("9f4b727c-2fb2-47f8-a144-9ae44dc7fd0e"),
                            CarMakeId = 2,
                            CarModel = "Golf VIII",
                            ColorId = 1,
                            Name = "Milan's Golf",
                            NumberOfSeats = 5,
                            Plates = "BJ-513-DD"
                        },
                        new
                        {
                            Id = new Guid("fe37d357-0315-419d-9ec8-703becdbc3a4"),
                            CarMakeId = 9,
                            CarModel = "Mustang",
                            ColorId = 9,
                            Name = "John's Mustang",
                            NumberOfSeats = 3,
                            Plates = "ZG-5220-IG"
                        },
                        new
                        {
                            Id = new Guid("b699b060-db26-4353-972b-a6b657ea7acc"),
                            CarMakeId = 10,
                            CarModel = "V60",
                            ColorId = 3,
                            Name = "Patricia's Volvo",
                            NumberOfSeats = 5,
                            Plates = "DU-555-PP"
                        },
                        new
                        {
                            Id = new Guid("a2bffa7b-f8b4-418e-b025-9f1d6a721836"),
                            CarMakeId = 5,
                            CarModel = "Supra",
                            ColorId = 4,
                            Name = "Josip's Toyota",
                            NumberOfSeats = 3,
                            Plates = "PU-2224-DC"
                        },
                        new
                        {
                            Id = new Guid("afb2cfd7-0a2c-4a94-8a5d-940dae9de89d"),
                            CarMakeId = 1,
                            CarModel = "Superb",
                            ColorId = 8,
                            Name = "Damir's Skoda",
                            NumberOfSeats = 5,
                            Plates = "ST-555-BD"
                        },
                        new
                        {
                            Id = new Guid("16b94982-d53d-46c4-988a-28e0d067144e"),
                            CarMakeId = 3,
                            CarModel = "A5",
                            ColorId = 10,
                            Name = "Ivan's Auid",
                            NumberOfSeats = 3,
                            Plates = "PU-333-DB"
                        },
                        new
                        {
                            Id = new Guid("d5c08ae4-8fea-4335-927d-61cbbcc74c5d"),
                            CarMakeId = 4,
                            CarModel = "Leon",
                            ColorId = 2,
                            Name = "Lana's Seat",
                            NumberOfSeats = 5,
                            Plates = "KC-222-DA"
                        },
                        new
                        {
                            Id = new Guid("7f645e8f-6d70-4c6f-8c26-8ab086d6d090"),
                            CarMakeId = 8,
                            CarModel = "Sandero",
                            ColorId = 3,
                            Name = "Silvija's Dacia",
                            NumberOfSeats = 5,
                            Plates = "NA-221-IA"
                        },
                        new
                        {
                            Id = new Guid("aa71e878-65e1-433f-82c2-ead76ae54dc2"),
                            CarMakeId = 6,
                            CarModel = "SX4",
                            ColorId = 6,
                            Name = "Tomislav's Suzuki",
                            NumberOfSeats = 5,
                            Plates = "B-444-AA"
                        },
                        new
                        {
                            Id = new Guid("a408f344-9089-425a-aa2d-9b19a57d456c"),
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
                            Id = new Guid("a2838c0a-f113-4b50-bf99-78e0c411a9ea"),
                            EmployeeId = 1,
                            EmployeeName = "Ivan Kranjec",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("e661a87f-f1c5-46b5-b79c-9806b3c54ec4"),
                            EmployeeId = 2,
                            EmployeeName = "Damir Rose",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("4a09509a-931f-4337-b7b0-34eaba5582ab"),
                            EmployeeId = 3,
                            EmployeeName = "Ana Lazaric",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("ae781d44-1fd0-4076-bcf1-278a04c1cfb5"),
                            EmployeeId = 4,
                            EmployeeName = "Thomas Horvar",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("53e0cfa6-e244-407f-aaa6-bf29af321adf"),
                            EmployeeId = 5,
                            EmployeeName = "Marko Mlinarić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("fda3363a-9796-46ff-9871-6e1bded9eb8c"),
                            EmployeeId = 6,
                            EmployeeName = "Josip Tandara",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("f9745ec4-6b55-4162-889f-65868976ebf9"),
                            EmployeeId = 7,
                            EmployeeName = "Marin Horvat",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("8102a731-b943-4bbf-946b-85180eee4bc1"),
                            EmployeeId = 8,
                            EmployeeName = "Dino Jelusić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("1aa38154-d60f-46df-921c-a19cd6acc01e"),
                            EmployeeId = 9,
                            EmployeeName = "Miroslav Škoro",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("e4bc71ce-6e58-463a-a0d0-27224a423580"),
                            EmployeeId = 10,
                            EmployeeName = "Hrvoje Plenk",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("a4a1d54f-f4fc-4a84-b9fa-7c22de45a3db"),
                            EmployeeId = 11,
                            EmployeeName = "Matej Dušan",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("2eca242a-aa01-4e7f-a5a2-bacf82276543"),
                            EmployeeId = 12,
                            EmployeeName = "Peter Pan",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("99469e79-ced5-4a40-b16e-ddaceb33a95d"),
                            EmployeeId = 13,
                            EmployeeName = "Hrvoje Mirić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("0cbec616-ee1f-40a1-bf63-7311cb843d47"),
                            EmployeeId = 14,
                            EmployeeName = "Jasna Gruber",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("76d53678-4760-41b1-a1a0-0dd8ce7685d5"),
                            EmployeeId = 15,
                            EmployeeName = "Mario Budimir",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("f8ebd6aa-a132-486a-90d8-966bd775cda4"),
                            EmployeeId = 16,
                            EmployeeName = "Igor Babić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("7115789c-ed56-478a-b1db-546b4e2828f8"),
                            EmployeeId = 17,
                            EmployeeName = "Marija Husar",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("52cf73ac-0f26-4fc1-8ac0-725122042f17"),
                            EmployeeId = 18,
                            EmployeeName = "Melita Huskvarnić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("df92b26b-8861-4a62-b095-cec8d48f3770"),
                            EmployeeId = 19,
                            EmployeeName = "Lana Jurčević",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("d81bd701-dc13-4d43-ae4d-385e2a753452"),
                            EmployeeId = 20,
                            EmployeeName = "Mihaela Dubrovnik",
                            IsDriver = false
                        },
                        new
                        {
                            Id = new Guid("64bdff26-9e14-4ab4-a87b-e5a82d712e5d"),
                            EmployeeId = 21,
                            EmployeeName = "Ivan Ivanović",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("f092be95-20e2-48a9-b034-5c089ca8ec03"),
                            EmployeeId = 22,
                            EmployeeName = "Luka Cvrtila",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("1eaefffd-6892-4d5c-8790-c5c3bf402f6e"),
                            EmployeeId = 23,
                            EmployeeName = "Dubravko Marček",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("d68ec4e2-7333-44ad-9e17-f48756d33ef0"),
                            EmployeeId = 24,
                            EmployeeName = "Dubravka Martinić",
                            IsDriver = true
                        },
                        new
                        {
                            Id = new Guid("62ec7789-d849-4e2e-b690-aab3df1ef939"),
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

            modelBuilder.Entity("Carpool.Domain.Entities.City", b =>
                {
                    b.HasOne("Carpool.Domain.Entities.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("County");
                });
#pragma warning restore 612, 618
        }
    }
}
