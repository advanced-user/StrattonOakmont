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
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Сapitalization = table.Column<long>(type: "bigint", nullable: false),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
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
                name: "SecurityInds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "SecuritySubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Securities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Securities_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Bonds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    CompanySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bonds_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bonds_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bonds_Companies_CompanySecId",
                        column: x => x.CompanySecId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bonds_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
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
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Divisibility = table.Column<bool>(type: "bit", nullable: false),
                    SecurityId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    CompanySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Companies_CompanySecId",
                        column: x => x.CompanySecId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
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
                    StoсkId = table.Column<int>(type: "int", nullable: true),
                    BondId = table.Column<int>(type: "int", nullable: true),
                    SecuritySubId = table.Column<int>(type: "int", nullable: true),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_Bonds_BondId",
                        column: x => x.BondId,
                        principalTable: "Bonds",
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
                        name: "FK_DepositReceipts_Stocks_StoсkId",
                        column: x => x.StoсkId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: true),
                    BondId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Bonds_BondId",
                        column: x => x.BondId,
                        principalTable: "Bonds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
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
                        name: "FK_Wrights_SecurityInds_SecurityIndId",
                        column: x => x.SecurityIndId,
                        principalTable: "SecurityInds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wrights_Stocks_ActiveId",
                        column: x => x.ActiveId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PriceСhanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BondId = table.Column<int>(type: "int", nullable: true),
                    StoсkId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    DepositReceiptsId = table.Column<int>(type: "int", nullable: true),
                    ForwardId = table.Column<int>(type: "int", nullable: true),
                    FuturesId = table.Column<int>(type: "int", nullable: true),
                    OptionId = table.Column<int>(type: "int", nullable: true),
                    WrightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceСhanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_Bonds_BondId",
                        column: x => x.BondId,
                        principalTable: "Bonds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_DepositReceipts_DepositReceiptsId",
                        column: x => x.DepositReceiptsId,
                        principalTable: "DepositReceipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_Forwards_ForwardId",
                        column: x => x.ForwardId,
                        principalTable: "Forwards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_Futures_FuturesId",
                        column: x => x.FuturesId,
                        principalTable: "Futures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_Stocks_StoсkId",
                        column: x => x.StoсkId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PriceСhanges_Wrights_WrightId",
                        column: x => x.WrightId,
                        principalTable: "Wrights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Bonds_CategorySecId",
                table: "Bonds",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Bonds_CompanySecId",
                table: "Bonds",
                column: "CompanySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Bonds_SecurityId",
                table: "Bonds",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bonds_UserSecId",
                table: "Bonds",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_BondId",
                table: "DepositReceipts",
                column: "BondId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_CategorySecId",
                table: "DepositReceipts",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_SecuritySubId",
                table: "DepositReceipts",
                column: "SecuritySubId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_StoсkId",
                table: "DepositReceipts",
                column: "StoсkId");

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
                name: "IX_PriceСhanges_BillId",
                table: "PriceСhanges",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceСhanges_BondId",
                table: "PriceСhanges",
                column: "BondId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceСhanges_DepositReceiptsId",
                table: "PriceСhanges",
                column: "DepositReceiptsId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceСhanges_ForwardId",
                table: "PriceСhanges",
                column: "ForwardId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceСhanges_FuturesId",
                table: "PriceСhanges",
                column: "FuturesId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceСhanges_OptionId",
                table: "PriceСhanges",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceСhanges_StoсkId",
                table: "PriceСhanges",
                column: "StoсkId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceСhanges_WrightId",
                table: "PriceСhanges",
                column: "WrightId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_BondId",
                table: "Receipts",
                column: "BondId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_CompanyId",
                table: "Receipts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_StockId",
                table: "Receipts",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_UserId",
                table: "Receipts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_CategoryId",
                table: "Securities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_CompanyId",
                table: "Securities",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SecurityInds_CategoryId",
                table: "SecurityInds",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SecuritySubs_CategoryId",
                table: "SecuritySubs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_CategorySecId",
                table: "Stocks",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_CompanySecId",
                table: "Stocks",
                column: "CompanySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_SecurityId",
                table: "Stocks",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_UserSecId",
                table: "Stocks",
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
        }

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
                name: "PriceСhanges");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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
                name: "Wrights");

            migrationBuilder.DropTable(
                name: "Bonds");

            migrationBuilder.DropTable(
                name: "Indastrials");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "SecurityInds");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Securities");

            migrationBuilder.DropTable(
                name: "SecuritySubs");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
