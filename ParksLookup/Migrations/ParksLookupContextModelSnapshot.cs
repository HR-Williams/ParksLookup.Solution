﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookup.Models;

namespace ParksLookup.Migrations
{
    [DbContext(typeof(ParksLookupContext))]
    partial class ParksLookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksLookup.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IndigenousLand")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Location")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 3,
                            IndigenousLand = "Chit-dee-ni (Chetco) and Tolowa Dee-ni’",
                            Location = "Near Brookings, Oregon, United States",
                            Name = "Alfred A. Loeb",
                            Type = "state"
                        },
                        new
                        {
                            ParkId = 4,
                            IndigenousLand = "Cayuse, Umatilla and Walla Walla, Confederated Tribes of Warm Springs",
                            Location = "Near John Day, Oregon, United States",
                            Name = "Bates State Park",
                            Type = "state"
                        },
                        new
                        {
                            ParkId = 5,
                            IndigenousLand = "Abenaki / Abénaquis, Penobscot, and Wabanaki Confederacy",
                            Location = "Maine",
                            Name = "Acadia",
                            Type = "national"
                        },
                        new
                        {
                            ParkId = 6,
                            IndigenousLand = "Núu-agha-tʉvʉ-pʉ̱ (Ute)",
                            Location = "Utah",
                            Name = "Arches",
                            Type = "national"
                        },
                        new
                        {
                            ParkId = 7,
                            IndigenousLand = "Cheyenne, Mnicoujou, Očhéthi Šakówiŋ",
                            Location = "South Dakota",
                            Name = "Badlands",
                            Type = "national"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
