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
                    Price = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId1 = table.Column<int>(type: "int", nullable: true),
                    ListingStatusId = table.Column<int>(type: "int", nullable: true),
                    ListingTypeId = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Server/Migrations/20240129015358_newdb.cs
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9eebdbd4-d827-4b23-8a3c-436f99419bb1", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMQAdjzTChuYf533sheHPQ64LoMkvMlA6Bm9/8LY8EAy1oOAFTOpiuV8JAuUPFMPyg==", null, false, "3f100d66-7a20-4df5-9b8e-e5f7e101dcf6", false, "admin@localhost.com" },
                    { "673b6b78-250e-422e-9e4c-bae4bb50db41", 0, "ebfa43f6-b823-46ad-8634-dcca97a409bf", "ggwp@gmail.com", false, "Tom", "Tan", false, null, "GGWP@GMAIL.COM", "GGWP@GMAIL.COM", "AQAAAAIAAYagAAAAEBRjGJQLfhe+ghq6LEXS6STcla9iqsBnv7vHB/vYHQQk0q9nZ0Tmhko+H47w3NWUOQ==", null, false, "8f2cc0c6-c5ba-441c-ad67-af2812e995d5", false, "ggwp@gmail.com" },
                    { "c3a0c046-d1b0-4607-a5d9-78b32026709c", 0, "f2b9b08a-5b6c-4bcb-b2ac-97089a9a41b1", "staff@gmail.com", false, "Mary", "Tan", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAIAAYagAAAAEF+qL3tuuT/ugHqyuk3GL9mpQXr2C96574fQLli2+KBdiRAi17HsdyXo6jdQ0nqv+g==", null, false, "5c259c35-011c-4099-bc0a-9fa9e4bcadff", false, "staff@gmail.com" }
========
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0f9fa3ee-172c-4e65-aa6a-fa51bf3d45df", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEZ+DyeGIUSirxtZ84Q+ROytwcSIPPdZMKFItZdZH5RJwnjAqylYDR1vaGXXlSIWTQ==", null, false, "348e5133-a02c-470a-a782-0c910b996b85", false, "admin@localhost.com" },
                    { "673b6b78-250e-422e-9e4c-bae4bb50db41", 0, "eeb9cc6e-741e-45d9-bb4a-5f0620b027f7", "ggwp@gmail.com", false, "Tom", "Tan", false, null, "GGWP@GMAIL.COM", "GGWP@GMAIL.COM", "AQAAAAIAAYagAAAAEN3eZrqVyqDIi2ZwtM2AMHRJXtnH00t22H7s2GNNAXnBbuIJuMfkqmB6+qmnPQ12AA==", null, false, "e8c9fc98-adce-4c6a-a279-8eba53db9789", false, "ggwp@gmail.com" },
                    { "c3a0c046-d1b0-4607-a5d9-78b32026709c", 0, "adc4a9f3-e343-46d2-b77f-99296683ed84", "staff@gmail.com", false, "Mary", "Tan", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAIAAYagAAAAEOK5/AyighFMkNkbGYwSg9782TQ0RA+PIn+gzx/D2Cg6yL7iVQ6VgFKQD2GBnvkpOA==", null, false, "e0d04d6b-c881-4bc1-a431-92750feec126", false, "staff@gmail.com" }
>>>>>>>> 81de93344a50fe215b0043efaa25e44c664fdd5f:Server/Migrations/20240129172939_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:Server/Migrations/20240129015358_newdb.cs
                    { 1, "System", new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9947), "Phone" },
                    { 2, "System", new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9950), "Figure" }
========
                    { 1, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7174), "Phone" },
                    { 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7176), "Figure" },
                    { 3, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7178), "Electronics" },
                    { 4, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7179), "Furniture" },
                    { 5, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7181), "Clothing & Accessories" },
                    { 6, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7182), "Home & Garden" },
                    { 7, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7184), "Books & Media" },
                    { 8, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7185), "Sports & Outdoors" },
                    { 9, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7187), "Toys & Games" }
>>>>>>>> 81de93344a50fe215b0043efaa25e44c664fdd5f:Server/Migrations/20240129172939_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "ConditionTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:Server/Migrations/20240129015358_newdb.cs
                    { 1, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(180), "New" },
                    { 2, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(181), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(182), "Well Used" },
                    { 3, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(184), "Damaged" }
========
                    { 1, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7336), "New" },
                    { 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7338), "Well Used" },
                    { 3, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7339), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7339), "Damaged" }
>>>>>>>> 81de93344a50fe215b0043efaa25e44c664fdd5f:Server/Migrations/20240129172939_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "ListingStatus",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:Server/Migrations/20240129015358_newdb.cs
                    { 1, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1215), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1216), "Avaliable" },
                    { 2, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1218), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1219), "Sold" }
========
                    { 1, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7613), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7613), "Avaliable" },
                    { 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7615), "Sold" }
>>>>>>>> 81de93344a50fe215b0043efaa25e44c664fdd5f:Server/Migrations/20240129172939_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "ListingType",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:Server/Migrations/20240129015358_newdb.cs
                    { 1, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(855), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(856), "Sell" },
                    { 2, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(858), "Swap" },
                    { 3, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(860), "Sell and Swap" }
========
                    { 1, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7481), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7481), "Sell" },
                    { 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7483), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7483), "Swap" },
                    { 3, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7484), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7485), "Sell and Swap" }
>>>>>>>> 81de93344a50fe215b0043efaa25e44c664fdd5f:Server/Migrations/20240129172939_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "AccountId", "AccountId1", "CategoryId", "ConditionTypeId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Lister", "ListerId", "ListingStatusId", "ListingTypeId", "Name", "Price" },
                values: new object[,]
                {
<<<<<<<< HEAD:Server/Migrations/20240129015358_newdb.cs
                    { 1, null, null, 1, 2, "System", new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9496), "well used without a scratch", null, null, 1, 1, "Iphone", 1200 },
                    { 2, null, null, 1, 1, "System", new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 1, 29, 9, 53, 57, 897, DateTimeKind.Local).AddTicks(9504), "well used without a scratch", null, null, 1, 2, "POP Mart figure", null }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "Id", "AccountId", "AccountId1", "CreatedBy", "DateCreated", "DateUpdated", "ListingId" },
                values: new object[,]
                {
                    { 1, null, null, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1447), 1 },
                    { 2, null, null, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1455), 2 }
========
                    { 1, null, null, 1, 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6826), "well used without a scratch", null, null, 1, 1, "Iphone", 1200 },
                    { 2, null, null, 1, 1, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6829), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6830), "well used without a scratch", null, null, 1, 2, "POP Mart figure", null },
                    { 3, null, null, 3, 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6832), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6833), "Full HD Smart TV with great picture quality", null, null, 1, 1, "Smart TV", 800 },
                    { 4, null, null, 4, 3, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6836), "Comfortable leather sofa in excellent condition", null, null, 1, 1, "Leather Sofa", 500 },
                    { 5, null, null, 5, 1, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6839), "Stylish men's winter jacket, size XL", null, null, 1, 1, "Men's Winter Jacket", 80 },
                    { 6, null, null, 6, 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6841), "Outdoor table and chairs set for your garden", null, null, 1, 1, "Garden Table and Chairs", 150 },
                    { 7, null, null, 7, 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6844), "Complete set of Harry Potter books in good condition", null, null, 1, 2, "Harry Potter Book Set", 60 },
                    { 8, null, null, 8, 3, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6846), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6847), "Hardtail mountain bike with front suspension", null, null, 1, 1, "Mountain Bike", 300 },
                    { 9, null, null, 1, 2, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6849), "Brand new in box, never opened.", null, null, 1, 1, "Samsung Galaxy S21", 899 },
                    { 10, null, null, 9, 1, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6852), "Complete set with original box.", null, null, 1, 2, "Lego Star Wars Millennium Falcon", 150 },
                    { 11, null, null, 3, 3, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(6854), "Used but in excellent condition.", null, null, 1, 1, "Amazon Echo Dot (3rd Gen)", 30 }
>>>>>>>> 81de93344a50fe215b0043efaa25e44c664fdd5f:Server/Migrations/20240129172939_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AccountId", "Buyer", "BuyerId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ListingId", "Price", "Reason", "Status" },
                values: new object[,]
                {
<<<<<<<< HEAD:Server/Migrations/20240129015358_newdb.cs
                    { 1, null, null, null, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1688), "", 1, 10, null, "Pending" },
                    { 2, null, null, null, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1707), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1708), "Really like it", 1, 100, null, "Pending" },
                    { 3, null, null, null, "System", new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 1, 29, 9, 53, 57, 898, DateTimeKind.Local).AddTicks(1710), "Really like it", 2, null, null, "Pending" }
========
                    { 1, null, null, null, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7748), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7748), "", 1, 10, null, "Pending" },
                    { 2, null, null, null, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7751), "Really like it", 1, 100, null, "Pending" },
                    { 3, null, null, null, "System", new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7753), new DateTime(2024, 1, 30, 1, 29, 39, 273, DateTimeKind.Local).AddTicks(7753), "Really like it", 2, null, null, "Pending" }
>>>>>>>> 81de93344a50fe215b0043efaa25e44c664fdd5f:Server/Migrations/20240129172939_newdb.cs
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
