﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SellSwap.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListingStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConditionTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId1 = table.Column<int>(type: "int", nullable: true),
                    ListingStatusId = table.Column<int>(type: "int", nullable: true),
                    ListingTypeId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Listings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Listings_ConditionTypes_ConditionTypeId",
                        column: x => x.ConditionTypeId,
                        principalTable: "ConditionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Listings_ListingStatus_ListingStatusId",
                        column: x => x.ListingStatusId,
                        principalTable: "ListingStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Listings_ListingType_ListingTypeId",
                        column: x => x.ListingTypeId,
                        principalTable: "ListingType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Listings_Users_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ListingId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conversations_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId1 = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Buyer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListingId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Offers_Users_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConversationId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessages_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c47d1606-154b-4b8d-a663-20e196f642da", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELi7kQg4I8gdnoB71Ad0XuslrvlvR7JYuZZUepF/GIsJ1kf9Q+xf4+QTVwfiLKsDXw==", null, false, "0b6df8eb-3114-4a0a-bfd9-6908b73410a9", false, "admin@localhost.com" },
                    { "673b6b78-250e-422e-9e4c-bae4bb50db41", 0, "87fd6832-0275-4bd9-8c69-88d871450d37", "ggwp@gmail.com", false, "Tom", "Tan", false, null, "GGWP@GMAIL.COM", "GGWP@GMAIL.COM", "AQAAAAIAAYagAAAAEGPcz8uIzY4XzFqCaKCGGStXQL2D+Qlyyu+DAf9+3yHDGsiLnipROMmGG27OAdyZcw==", null, false, "f5cc7bf6-4e2b-4610-9672-54b80a3a2ede", false, "ggwp@gmail.com" },
                    { "c3a0c046-d1b0-4607-a5d9-78b32026709c", 0, "dab893a7-6604-4124-ab24-04b3bd38f941", "staff@gmail.com", false, "Mary", "Tan", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAIAAYagAAAAEBDB71WhywrLb3QqqHT1dNfJRo0pJqbvDkMlAC/2OK6ep2odL1/sac1ZSuFE1awO+Q==", null, false, "230431a6-81dc-4566-a505-1885297c879d", false, "staff@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3102), "Phone" },
                    { 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3104), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3104), "Figure" },
                    { 3, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3106), "Electronics" },
                    { 4, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3107), "Furniture" },
                    { 5, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3108), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3109), "Clothing & Accessories" },
                    { 6, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3110), "Home & Garden" },
                    { 7, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3111), "Books & Media" },
                    { 8, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3112), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3113), "Sports & Outdoors" },
                    { 9, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3114), "Toys & Games" }
                });

            migrationBuilder.InsertData(
                table: "ConditionTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3285), "New" },
                    { 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3287), "Well Used" },
                    { 3, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3288), "Damaged" }
                });

            migrationBuilder.InsertData(
                table: "ListingStatus",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3592), "Avaliable" },
                    { 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3594), "Sold" }
                });

            migrationBuilder.InsertData(
                table: "ListingType",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3447), "Sell" },
                    { 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3448), "Swap" },
                    { 3, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3450), "Sell and Swap" }
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "AccountId", "AccountId1", "CategoryId", "ConditionTypeId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Image", "Lister", "ListerId", "ListingStatusId", "ListingTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, null, 1, 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2617), "well used without a scratch", "/images/iphone-15-finish-select-202309-6-1inch-black.jpg", null, null, 1, 1, "Iphone", 1200.0 },
                    { 2, null, null, 2, 1, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2620), "well used without a scratch", "/images/vn-11134207-7r98o-ll5dstlhxsjad9_880302e6f6444e4189236838fbb1c647.jpg", null, null, 1, 2, "POP Mart figure", null },
                    { 3, null, null, 3, 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2624), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2624), "Full HD Smart TV with great picture quality", "/images/Hisense-A4-32-HD-Smart-TV.jpg", null, null, 1, 1, "Smart TV", 800.0 },
                    { 4, null, null, 4, 3, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2626), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2627), "Comfortable leather sofa in excellent condition", "/images/_mg_9210_2.jpg", null, null, 1, 2, "Leather Sofa", 500.0 },
                    { 5, null, null, 5, 1, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2630), "Stylish men's winter jacket, size XL", "/images/download.jpg", null, null, 1, 1, "Men's Winter Jacket", 80.0 },
                    { 6, null, null, 6, 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2632), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2632), "Outdoor table and chairs set for your garden", "/images/img_0509-edit.jpg", null, null, 1, 1, "Garden Table and Chairs", 150.0 },
                    { 7, null, null, 7, 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2635), "Complete set of Harry Potter books in good condition", "/images/718X1SWIsjL._AC_UF1000,1000_QL80_.jpg", null, null, 1, 2, "Harry Potter Book Set", 60.0 },
                    { 8, null, null, 8, 3, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2637), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2637), "Hardtail mountain bike with front suspension", "/images/download (1).jpg", null, null, 1, 1, "Mountain Bike", 300.0 },
                    { 9, null, null, 1, 2, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2640), "Brand new in box, never opened.", "/images/81IWsqrVMTL._AC_UF894,1000_QL80_.jpg", null, null, 1, 2, "Samsung Galaxy S21", 899.99000000000001 },
                    { 10, null, null, 9, 1, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2642), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2643), "Complete set with original box.", "/images/81kmuPJ9IOL.jpg", null, null, 1, 2, "Lego Star Wars Millennium Falcon", null },
                    { 11, null, null, 3, 3, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(2648), "Used but in excellent condition.", "/images/amazon_echo_dot_3__echo_dot_3r_1610044909_d1b25298_progressive.jpg", null, null, 1, 1, "Amazon Echo Dot (3rd Gen)", 30.0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AccountId", "Buyer", "BuyerId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ListingId", "Price", "Reason", "Status" },
                values: new object[,]
                {
                    { 1, null, null, null, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3745), "", 1, 10, null, "Pending" },
                    { 2, null, null, null, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3747), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3747), "Really like it", 1, 100, null, "Pending" },
                    { 3, null, null, null, "System", new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3749), new DateTime(2024, 2, 4, 13, 18, 25, 918, DateTimeKind.Local).AddTicks(3749), "Really like it", 2, null, null, "Pending" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ConversationId",
                table: "ChatMessages",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_ListingId",
                table: "Conversations",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_AccountId1",
                table: "Favorites",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ListingId",
                table: "Favorites",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_AccountId1",
                table: "Listings",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_CategoryId",
                table: "Listings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_ConditionTypeId",
                table: "Listings",
                column: "ConditionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_ListingStatusId",
                table: "Listings",
                column: "ListingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_ListingTypeId",
                table: "Listings",
                column: "ListingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_AccountId",
                table: "Offers",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ListingId",
                table: "Offers",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropTable(
                name: "Listings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ConditionTypes");

            migrationBuilder.DropTable(
                name: "ListingStatus");

            migrationBuilder.DropTable(
                name: "ListingType");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
