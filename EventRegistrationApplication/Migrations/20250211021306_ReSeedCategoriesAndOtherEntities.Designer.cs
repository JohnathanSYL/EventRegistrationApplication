﻿// <auto-generated />
using System;
using EventRegistrationApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventRegistrationApplication.Migrations
{
    [DbContext(typeof(EventRegistrationApplicationContext))]
    [Migration("20250211021306_ReSeedCategoriesAndOtherEntities")]
    partial class ReSeedCategoriesAndOtherEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventRegistrationApplication.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Sports & Fitness",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3709),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3734),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Music & Concert",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3743),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3744),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Movies",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3749),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3750),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Arts & Culture",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3761),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3762),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Conferences & Seminars",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3766),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3767),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Education & Workshops",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3770),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3772),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Festivals & Celebrations",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3776),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3777),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Trade Shows & Expos",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3780),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3782),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Science & Innovation",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3785),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3786),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Gaming & Esports",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3790),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3791),
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("EventRegistrationApplication.Domain.EventModel", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.ToTable("EventModel");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            CategoryId = 1,
                            CreatedBy = "System",
                            Date = new DateTime(2025, 5, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4419),
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4465),
                            DateIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4490),
                            Description = "A thrilling Premier League clash between Liverpool and Man City.",
                            EventName = "Football Match: Liverpool vs Man City",
                            Location = "National Stadium",
                            StatusId = 1,
                            UpdatedBy = "System",
                            UserId = 1,
                            VenueId = 1
                        },
                        new
                        {
                            EventId = 2,
                            CategoryId = 2,
                            CreatedBy = "System",
                            Date = new DateTime(2025, 6, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4495),
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4499),
                            DateIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4500),
                            Description = "A captivating music concert by JJ Lin, featuring his iconic hits.",
                            EventName = "Music Event: Music Concert by JJ Lin",
                            Location = "Singapore Indoor Stadium",
                            StatusId = 1,
                            UpdatedBy = "System",
                            UserId = 1,
                            VenueId = 2
                        },
                        new
                        {
                            EventId = 3,
                            CategoryId = 3,
                            CreatedBy = "System",
                            Date = new DateTime(2025, 7, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4504),
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4507),
                            DateIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4508),
                            Description = "An epic movie showdown between Godzilla and Groot.",
                            EventName = "Movie Event: Godzilla Vs Groot",
                            Location = "Gateway Theatre (Main Theatre)",
                            StatusId = 1,
                            UpdatedBy = "System",
                            UserId = 1,
                            VenueId = 3
                        },
                        new
                        {
                            EventId = 4,
                            CategoryId = 3,
                            CreatedBy = "System",
                            Date = new DateTime(2025, 8, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4542),
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4545),
                            DateIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4546),
                            Description = "Hello Kitty enters the titan battle, joining forces with the Attack on Titan crew in an unexpected crossover!",
                            EventName = "Movie Event: Hello Kitty joined the fight of the titans! ft Attack on Titans",
                            Location = "Gateway Theatre (Main Theatre)",
                            StatusId = 1,
                            UpdatedBy = "System",
                            UserId = 1,
                            VenueId = 3
                        },
                        new
                        {
                            EventId = 5,
                            CategoryId = 1,
                            CreatedBy = "System",
                            Date = new DateTime(2025, 9, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4550),
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4553),
                            DateIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4554),
                            Description = "Arsenal will take on Newcastle in a high-stakes Carabao Cup clash at the Emirates, aiming to bounce back from a tough first-leg result.",
                            EventName = "Football Match: Arsenal vs Newcastle",
                            Location = "National Stadium",
                            StatusId = 1,
                            UpdatedBy = "System",
                            UserId = 1,
                            VenueId = 1
                        },
                        new
                        {
                            EventId = 6,
                            CategoryId = 2,
                            CreatedBy = "System",
                            Date = new DateTime(2025, 12, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4558),
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4561),
                            DateIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4562),
                            Description = "Enjoy an unforgettable night of soulful melodies and powerful performances at G.E.M's music concert!",
                            EventName = "Music Event: Music Concert by G.E.M",
                            Location = "Singapore Indoor Stadium",
                            StatusId = 1,
                            UpdatedBy = "System",
                            UserId = 1,
                            VenueId = 2
                        });
                });

            modelBuilder.Entity("EventRegistrationApplication.Domain.EventRegistrationApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e83ea98f-faff-431b-8e85-59e23a25a6a4",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(8650),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(8675),
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIsi/crHTsWTGLoyEzHvZQKCYzXJ6IDi5mNfKFNEck+jaXF6ECb3F4ertL7885DNRQ==",
                            PhoneNumber = "123-456-7890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4156acdb-90f0-4428-a01c-232f9319fb54",
                            TwoFactorEnabled = false,
                            UpdatedBy = "System",
                            UserName = "admin@localhost.com"
                        });
                });

            modelBuilder.Entity("EventRegistrationApplication.Domain.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistrationId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeatsReserved")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RegistrationId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Registration");

                    b.HasData(
                        new
                        {
                            RegistrationId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4782),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4783),
                            EventId = 1,
                            RegistrationDate = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4780),
                            SeatsReserved = 2,
                            UpdatedBy = "System",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EventRegistrationApplication.Domain.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5331),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5332),
                            StatusName = "Active",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            StatusId = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5337),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5338),
                            StatusName = "Inactive",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("EventRegistrationApplication.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicPreferences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EventRegistrationApplication.Domain.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueId");

                    b.ToTable("Venue");

                    b.HasData(
                        new
                        {
                            VenueId = 1,
                            Capacity = 55000,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9945),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9949),
                            Location = "Singapore",
                            UpdatedBy = "System",
                            VenueName = "National Stadium"
                        },
                        new
                        {
                            VenueId = 2,
                            Capacity = 12000,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9955),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9957),
                            Location = "Singapore",
                            UpdatedBy = "System",
                            VenueName = "Singapore Indoor Stadium"
                        },
                        new
                        {
                            VenueId = 3,
                            Capacity = 922,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9962),
                            DateUpdated = new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9963),
                            Location = "Singapore",
                            UpdatedBy = "System",
                            VenueName = "Gateway Theatre (Main Theatre)"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EventRegistrationApplication.Domain.Registration", b =>
                {
                    b.HasOne("EventRegistrationApplication.Domain.EventModel", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventRegistrationApplication.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EventRegistrationApplication.Domain.EventRegistrationApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EventRegistrationApplication.Domain.EventRegistrationApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventRegistrationApplication.Domain.EventRegistrationApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EventRegistrationApplication.Domain.EventRegistrationApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
