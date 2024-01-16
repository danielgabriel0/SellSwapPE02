﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SellSwap.Server.Data;

#nullable disable

namespace SellSwap.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SellSwap.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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
                            ConcurrencyStamp = "a290f542-6418-4f35-8960-e1a6cb3fdbb9",
                            Email = "admin@localhost.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMFlnfbqHD8h1uxiiC3adgAdeA5R5hjcSesE8+Y8wNUOQnchRPDvzoptEX88hq+YnQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a55d991c-7bcf-4cea-9189-58b8982de9e0",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5681),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5682),
                            Name = "Phone"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5684),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5684),
                            Name = "Figure"
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.ConditionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConditionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5868),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5868),
                            Name = "New"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5870),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5871),
                            Name = "WellUsed"
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Favourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6413),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6413),
                            ListingId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6415),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6416),
                            ListingId = 2
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ConditionTypeId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ListingStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("ListingTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ConditionTypeId");

                    b.HasIndex("ListingStatusId");

                    b.HasIndex("ListingTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Listings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ConditionTypeId = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5319),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5329),
                            Description = "well used without a scratch",
                            ListingStatusId = 1,
                            ListingTypeId = 1,
                            Name = "Iphone",
                            Price = 1200
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ConditionTypeId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5333),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(5334),
                            Description = "well used without a scratch",
                            ListingStatusId = 1,
                            ListingTypeId = 2,
                            Name = "POP Mart figure"
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.ListingStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListingStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6237),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6237),
                            Name = "Avaliable"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6238),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6239),
                            Name = "Sold"
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.ListingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListingType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6059),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6060),
                            Name = "Sell"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6061),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6062),
                            Name = "Swap"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6063),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6064),
                            Name = "Sell and Swap"
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ListingId")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.HasIndex("UserId");

                    b.ToTable("Offers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6599),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6600),
                            ListingId = 1,
                            Price = 10
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6602),
                            DateUpdated = new DateTime(2024, 1, 16, 20, 28, 59, 434, DateTimeKind.Local).AddTicks(6603),
                            ListingId = 1,
                            Price = 100
                        });
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
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
                    b.HasOne("SellSwap.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SellSwap.Server.Models.ApplicationUser", null)
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

                    b.HasOne("SellSwap.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SellSwap.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Favourite", b =>
                {
                    b.HasOne("SellSwap.Shared.Domain.Listing", "Listing")
                        .WithMany("Favourites")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellSwap.Shared.Domain.User", "User")
                        .WithMany("Favourites")
                        .HasForeignKey("UserId");

                    b.Navigation("Listing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Listing", b =>
                {
                    b.HasOne("SellSwap.Shared.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("SellSwap.Shared.Domain.ConditionType", "ConditionType")
                        .WithMany()
                        .HasForeignKey("ConditionTypeId");

                    b.HasOne("SellSwap.Shared.Domain.ListingStatus", "ListingStatus")
                        .WithMany()
                        .HasForeignKey("ListingStatusId");

                    b.HasOne("SellSwap.Shared.Domain.ListingType", "ListingType")
                        .WithMany()
                        .HasForeignKey("ListingTypeId");

                    b.HasOne("SellSwap.Shared.Domain.User", "User")
                        .WithMany("Listing")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("ConditionType");

                    b.Navigation("ListingStatus");

                    b.Navigation("ListingType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Offer", b =>
                {
                    b.HasOne("SellSwap.Shared.Domain.Listing", "Listing")
                        .WithMany()
                        .HasForeignKey("ListingId");

                    b.HasOne("SellSwap.Shared.Domain.User", "User")
                        .WithMany("Offer")
                        .HasForeignKey("UserId");

                    b.Navigation("Listing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.Listing", b =>
                {
                    b.Navigation("Favourites");
                });

            modelBuilder.Entity("SellSwap.Shared.Domain.User", b =>
                {
                    b.Navigation("Favourites");

                    b.Navigation("Listing");

                    b.Navigation("Offer");
                });
#pragma warning restore 612, 618
        }
    }
}
