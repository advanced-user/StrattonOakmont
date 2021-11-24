using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StrattonOakmontServices.Migrations
{
    public partial class InitDb : Migration
    {
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
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
                name: "Dates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    AbligationId = table.Column<int>(type: "int", nullable: true),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    DepositReceiptsId = table.Column<int>(type: "int", nullable: true),
                    ForwardId = table.Column<int>(type: "int", nullable: true),
                    FuturesId = table.Column<int>(type: "int", nullable: true),
                    OptionId = table.Column<int>(type: "int", nullable: true),
                    StonkId = table.Column<int>(type: "int", nullable: true),
                    WrightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Securities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Securities_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Securities_Dates_DateId",
                        column: x => x.DateId,
                        principalTable: "Dates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecurityInds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityInds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityInds_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SecurityInds_Dates_DateId",
                        column: x => x.DateId,
                        principalTable: "Dates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecuritySubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecuritySubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecuritySubs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SecuritySubs_Dates_DateId",
                        column: x => x.DateId,
                        principalTable: "Dates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Сapitalization = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Indastrials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityIndId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indastrials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indastrials_SecurityInds_SecurityIndId",
                        column: x => x.SecurityIndId,
                        principalTable: "SecurityInds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecuritySubId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_SecuritySubs_SecuritySubId",
                        column: x => x.SecuritySubId,
                        principalTable: "SecuritySubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Abligations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    SecurityId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    CompanySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abligations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abligations_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abligations_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abligations_Companies_CompanySecId",
                        column: x => x.CompanySecId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abligations_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerSent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Getter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Setter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    LifeCycle = table.Column<int>(type: "int", nullable: false),
                    SecuritySubId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_SecuritySubs_SecuritySubId",
                        column: x => x.SecuritySubId,
                        principalTable: "SecuritySubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Forwards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameIndastry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    SecurityIndId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forwards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forwards_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Forwards_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Forwards_Indastrials_IndastrialSecId",
                        column: x => x.IndastrialSecId,
                        principalTable: "Indastrials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Forwards_SecurityInds_SecurityIndId",
                        column: x => x.SecurityIndId,
                        principalTable: "SecurityInds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Futures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameIndastry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    SecurityIndId = table.Column<int>(type: "int", nullable: true),
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Futures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Futures_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Futures_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Futures_Indastrials_IndastrialSecId",
                        column: x => x.IndastrialSecId,
                        principalTable: "Indastrials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Futures_SecurityInds_SecurityIndId",
                        column: x => x.SecurityIndId,
                        principalTable: "SecurityInds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameIndastry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    SecurityIndId = table.Column<int>(type: "int", nullable: true),
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Options_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Options_Indastrials_IndastrialSecId",
                        column: x => x.IndastrialSecId,
                        principalTable: "Indastrials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Options_SecurityInds_SecurityIndId",
                        column: x => x.SecurityIndId,
                        principalTable: "SecurityInds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stonks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Divisibility = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    SecurityId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    CompanySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stonks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stonks_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stonks_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stonks_Companies_CompanySecId",
                        column: x => x.CompanySecId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stonks_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wrights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameIndastry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActiveId = table.Column<int>(type: "int", nullable: true),
                    SecurityIndId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wrights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wrights_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wrights_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wrights_Indastrials_IndastrialSecId",
                        column: x => x.IndastrialSecId,
                        principalTable: "Indastrials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wrights_Securities_ActiveId",
                        column: x => x.ActiveId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wrights_SecurityInds_SecurityIndId",
                        column: x => x.SecurityIndId,
                        principalTable: "SecurityInds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepositReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    LifeCycle = table.Column<int>(type: "int", nullable: false),
                    StonkId = table.Column<int>(type: "int", nullable: true),
                    AbligationId = table.Column<int>(type: "int", nullable: true),
                    SecuritySubId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_Abligations_AbligationId",
                        column: x => x.AbligationId,
                        principalTable: "Abligations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_SecuritySubs_SecuritySubId",
                        column: x => x.SecuritySubId,
                        principalTable: "SecuritySubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_Stonks_StonkId",
                        column: x => x.StonkId,
                        principalTable: "Stonks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abligations_CategorySecId",
                table: "Abligations",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Abligations_CompanySecId",
                table: "Abligations",
                column: "CompanySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Abligations_SecurityId",
                table: "Abligations",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Abligations_UserSecId",
                table: "Abligations",
                column: "UserSecId");

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
                name: "IX_AspNetUsers_SecuritySubId",
                table: "AspNetUsers",
                column: "SecuritySubId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CategorySecId",
                table: "Bills",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_SecuritySubId",
                table: "Bills",
                column: "SecuritySubId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserSecId",
                table: "Bills",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SecurityId",
                table: "Companies",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_AbligationId",
                table: "Dates",
                column: "AbligationId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_BillId",
                table: "Dates",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_DepositReceiptsId",
                table: "Dates",
                column: "DepositReceiptsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ForwardId",
                table: "Dates",
                column: "ForwardId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_FuturesId",
                table: "Dates",
                column: "FuturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_OptionId",
                table: "Dates",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_StonkId",
                table: "Dates",
                column: "StonkId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_WrightId",
                table: "Dates",
                column: "WrightId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_AbligationId",
                table: "DepositReceipts",
                column: "AbligationId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_CategorySecId",
                table: "DepositReceipts",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_SecuritySubId",
                table: "DepositReceipts",
                column: "SecuritySubId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_StonkId",
                table: "DepositReceipts",
                column: "StonkId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_UserSecId",
                table: "DepositReceipts",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Forwards_CategorySecId",
                table: "Forwards",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Forwards_IndastrialSecId",
                table: "Forwards",
                column: "IndastrialSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Forwards_SecurityIndId",
                table: "Forwards",
                column: "SecurityIndId");

            migrationBuilder.CreateIndex(
                name: "IX_Forwards_UserSecId",
                table: "Forwards",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Futures_CategorySecId",
                table: "Futures",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Futures_IndastrialSecId",
                table: "Futures",
                column: "IndastrialSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Futures_SecurityIndId",
                table: "Futures",
                column: "SecurityIndId");

            migrationBuilder.CreateIndex(
                name: "IX_Futures_UserSecId",
                table: "Futures",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Indastrials_SecurityIndId",
                table: "Indastrials",
                column: "SecurityIndId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_CategorySecId",
                table: "Options",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_IndastrialSecId",
                table: "Options",
                column: "IndastrialSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_SecurityIndId",
                table: "Options",
                column: "SecurityIndId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_UserSecId",
                table: "Options",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_CategoryId",
                table: "Securities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_DateId",
                table: "Securities",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityInds_CategoryId",
                table: "SecurityInds",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityInds_DateId",
                table: "SecurityInds",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_SecuritySubs_CategoryId",
                table: "SecuritySubs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SecuritySubs_DateId",
                table: "SecuritySubs",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_Stonks_CategorySecId",
                table: "Stonks",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Stonks_CompanySecId",
                table: "Stonks",
                column: "CompanySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Stonks_SecurityId",
                table: "Stonks",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stonks_UserSecId",
                table: "Stonks",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Wrights_ActiveId",
                table: "Wrights",
                column: "ActiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Wrights_CategorySecId",
                table: "Wrights",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Wrights_IndastrialSecId",
                table: "Wrights",
                column: "IndastrialSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Wrights_SecurityIndId",
                table: "Wrights",
                column: "SecurityIndId");

            migrationBuilder.CreateIndex(
                name: "IX_Wrights_UserSecId",
                table: "Wrights",
                column: "UserSecId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Abligations_AbligationId",
                table: "Dates",
                column: "AbligationId",
                principalTable: "Abligations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Bills_BillId",
                table: "Dates",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_DepositReceipts_DepositReceiptsId",
                table: "Dates",
                column: "DepositReceiptsId",
                principalTable: "DepositReceipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Forwards_ForwardId",
                table: "Dates",
                column: "ForwardId",
                principalTable: "Forwards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Futures_FuturesId",
                table: "Dates",
                column: "FuturesId",
                principalTable: "Futures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Options_OptionId",
                table: "Dates",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Stonks_StonkId",
                table: "Dates",
                column: "StonkId",
                principalTable: "Stonks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Wrights_WrightId",
                table: "Dates",
                column: "WrightId",
                principalTable: "Wrights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abligations_AspNetUsers_UserSecId",
                table: "Abligations");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AspNetUsers_UserSecId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositReceipts_AspNetUsers_UserSecId",
                table: "DepositReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Forwards_AspNetUsers_UserSecId",
                table: "Forwards");

            migrationBuilder.DropForeignKey(
                name: "FK_Futures_AspNetUsers_UserSecId",
                table: "Futures");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_AspNetUsers_UserSecId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Stonks_AspNetUsers_UserSecId",
                table: "Stonks");

            migrationBuilder.DropForeignKey(
                name: "FK_Wrights_AspNetUsers_UserSecId",
                table: "Wrights");

            migrationBuilder.DropForeignKey(
                name: "FK_Abligations_Categories_CategorySecId",
                table: "Abligations");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Categories_CategorySecId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositReceipts_Categories_CategorySecId",
                table: "DepositReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Forwards_Categories_CategorySecId",
                table: "Forwards");

            migrationBuilder.DropForeignKey(
                name: "FK_Futures_Categories_CategorySecId",
                table: "Futures");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Categories_CategorySecId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Securities_Categories_CategoryId",
                table: "Securities");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityInds_Categories_CategoryId",
                table: "SecurityInds");

            migrationBuilder.DropForeignKey(
                name: "FK_SecuritySubs_Categories_CategoryId",
                table: "SecuritySubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Stonks_Categories_CategorySecId",
                table: "Stonks");

            migrationBuilder.DropForeignKey(
                name: "FK_Wrights_Categories_CategorySecId",
                table: "Wrights");

            migrationBuilder.DropForeignKey(
                name: "FK_Abligations_Companies_CompanySecId",
                table: "Abligations");

            migrationBuilder.DropForeignKey(
                name: "FK_Stonks_Companies_CompanySecId",
                table: "Stonks");

            migrationBuilder.DropForeignKey(
                name: "FK_Abligations_Securities_SecurityId",
                table: "Abligations");

            migrationBuilder.DropForeignKey(
                name: "FK_Stonks_Securities_SecurityId",
                table: "Stonks");

            migrationBuilder.DropForeignKey(
                name: "FK_Wrights_Securities_ActiveId",
                table: "Wrights");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_SecuritySubs_SecuritySubId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositReceipts_SecuritySubs_SecuritySubId",
                table: "DepositReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Abligations_AbligationId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositReceipts_Abligations_AbligationId",
                table: "DepositReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Bills_BillId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_DepositReceipts_DepositReceiptsId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Forwards_ForwardId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Futures_FuturesId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Options_OptionId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Stonks_StonkId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Wrights_WrightId",
                table: "Dates");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Securities");

            migrationBuilder.DropTable(
                name: "SecuritySubs");

            migrationBuilder.DropTable(
                name: "Abligations");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "DepositReceipts");

            migrationBuilder.DropTable(
                name: "Forwards");

            migrationBuilder.DropTable(
                name: "Futures");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Stonks");

            migrationBuilder.DropTable(
                name: "Wrights");

            migrationBuilder.DropTable(
                name: "Indastrials");

            migrationBuilder.DropTable(
                name: "SecurityInds");

            migrationBuilder.DropTable(
                name: "Dates");
        }
    }
}
