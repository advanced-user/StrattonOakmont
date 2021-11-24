using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StrattonOakmontServices.Migrations
{
    public partial class NewModelM : Migration
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Сapitalization = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indastrials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indastrials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecIndCons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecIndCons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecMainCons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecMainCons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecSubCons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecSubCons", x => x.Id);
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
                name: "SecurityInds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityInds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityInds_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SecurityInds_Categories_CategorySecId",
                        column: x => x.CategorySecId,
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
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    LifeCycle = table.Column<int>(type: "int", nullable: false),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecuritySubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecuritySubs_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SecuritySubs_Categories_CategorySecId",
                        column: x => x.CategorySecId,
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
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    CompanySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Securities_AspNetUsers_UserSecId",
                        column: x => x.UserSecId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Securities_Categories_CategorySecId",
                        column: x => x.CategorySecId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Securities_Companies_CompanySecId",
                        column: x => x.CompanySecId,
                        principalTable: "Companies",
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
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecIndConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_Forwards_SecIndCons_SecIndConId",
                        column: x => x.SecIndConId,
                        principalTable: "SecIndCons",
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
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecIndConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Futures_SecIndCons_SecIndConId",
                        column: x => x.SecIndConId,
                        principalTable: "SecIndCons",
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
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecIndConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Options_SecIndCons_SecIndConId",
                        column: x => x.SecIndConId,
                        principalTable: "SecIndCons",
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
                    SecMainConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Abligations_SecMainCons_SecMainConId",
                        column: x => x.SecMainConId,
                        principalTable: "SecMainCons",
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
                    SecMainConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Stonks_SecMainCons_SecMainConId",
                        column: x => x.SecMainConId,
                        principalTable: "SecMainCons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    SecSubConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    LifeCycle = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Bills_SecSubCons_SecSubConId",
                        column: x => x.SecSubConId,
                        principalTable: "SecSubCons",
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
                    IndastrialSecId = table.Column<int>(type: "int", nullable: true),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    FinalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveId = table.Column<int>(type: "int", nullable: true),
                    SecIndConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    CategorySecId = table.Column<int>(type: "int", nullable: true),
                    UserSecId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_Wrights_SecIndCons_SecIndConId",
                        column: x => x.SecIndConId,
                        principalTable: "SecIndCons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wrights_Securities_ActiveId",
                        column: x => x.ActiveId,
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
                    StonkId = table.Column<int>(type: "int", nullable: true),
                    AbligationId = table.Column<int>(type: "int", nullable: true),
                    SecSubConId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    LifeCycle = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_DepositReceipts_SecSubCons_SecSubConId",
                        column: x => x.SecSubConId,
                        principalTable: "SecSubCons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepositReceipts_Stonks_StonkId",
                        column: x => x.StonkId,
                        principalTable: "Stonks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_Dates_Abligations_AbligationId",
                        column: x => x.AbligationId,
                        principalTable: "Abligations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_DepositReceipts_DepositReceiptsId",
                        column: x => x.DepositReceiptsId,
                        principalTable: "DepositReceipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Forwards_ForwardId",
                        column: x => x.ForwardId,
                        principalTable: "Forwards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Futures_FuturesId",
                        column: x => x.FuturesId,
                        principalTable: "Futures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Stonks_StonkId",
                        column: x => x.StonkId,
                        principalTable: "Stonks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Wrights_WrightId",
                        column: x => x.WrightId,
                        principalTable: "Wrights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DateSecurity",
                columns: table => new
                {
                    DateTimesChangesId = table.Column<int>(type: "int", nullable: false),
                    SecuritiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateSecurity", x => new { x.DateTimesChangesId, x.SecuritiesId });
                    table.ForeignKey(
                        name: "FK_DateSecurity_Dates_DateTimesChangesId",
                        column: x => x.DateTimesChangesId,
                        principalTable: "Dates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DateSecurity_Securities_SecuritiesId",
                        column: x => x.SecuritiesId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DateSecurityInd",
                columns: table => new
                {
                    DateTimesChangesId = table.Column<int>(type: "int", nullable: false),
                    SecurityIndId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateSecurityInd", x => new { x.DateTimesChangesId, x.SecurityIndId });
                    table.ForeignKey(
                        name: "FK_DateSecurityInd_Dates_DateTimesChangesId",
                        column: x => x.DateTimesChangesId,
                        principalTable: "Dates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DateSecurityInd_SecurityInds_SecurityIndId",
                        column: x => x.SecurityIndId,
                        principalTable: "SecurityInds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DateSecuritySub",
                columns: table => new
                {
                    DateTimesChangesId = table.Column<int>(type: "int", nullable: false),
                    SecuritySubsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateSecuritySub", x => new { x.DateTimesChangesId, x.SecuritySubsId });
                    table.ForeignKey(
                        name: "FK_DateSecuritySub_Dates_DateTimesChangesId",
                        column: x => x.DateTimesChangesId,
                        principalTable: "Dates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DateSecuritySub_SecuritySubs_SecuritySubsId",
                        column: x => x.SecuritySubsId,
                        principalTable: "SecuritySubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Abligations_SecMainConId",
                table: "Abligations",
                column: "SecMainConId");

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
                name: "IX_Bills_SecSubConId",
                table: "Bills",
                column: "SecSubConId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserSecId",
                table: "Bills",
                column: "UserSecId");

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
                name: "IX_DateSecurity_SecuritiesId",
                table: "DateSecurity",
                column: "SecuritiesId");

            migrationBuilder.CreateIndex(
                name: "IX_DateSecurityInd_SecurityIndId",
                table: "DateSecurityInd",
                column: "SecurityIndId");

            migrationBuilder.CreateIndex(
                name: "IX_DateSecuritySub_SecuritySubsId",
                table: "DateSecuritySub",
                column: "SecuritySubsId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_AbligationId",
                table: "DepositReceipts",
                column: "AbligationId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_CategorySecId",
                table: "DepositReceipts",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositReceipts_SecSubConId",
                table: "DepositReceipts",
                column: "SecSubConId");

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
                name: "IX_Forwards_SecIndConId",
                table: "Forwards",
                column: "SecIndConId");

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
                name: "IX_Futures_SecIndConId",
                table: "Futures",
                column: "SecIndConId");

            migrationBuilder.CreateIndex(
                name: "IX_Futures_UserSecId",
                table: "Futures",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_CategorySecId",
                table: "Options",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_IndastrialSecId",
                table: "Options",
                column: "IndastrialSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_SecIndConId",
                table: "Options",
                column: "SecIndConId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_UserSecId",
                table: "Options",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_CategorySecId",
                table: "Securities",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_CompanySecId",
                table: "Securities",
                column: "CompanySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Securities_UserSecId",
                table: "Securities",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityInds_CategorySecId",
                table: "SecurityInds",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityInds_UserSecId",
                table: "SecurityInds",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_SecuritySubs_CategorySecId",
                table: "SecuritySubs",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_SecuritySubs_UserSecId",
                table: "SecuritySubs",
                column: "UserSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Stonks_CategorySecId",
                table: "Stonks",
                column: "CategorySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Stonks_CompanySecId",
                table: "Stonks",
                column: "CompanySecId");

            migrationBuilder.CreateIndex(
                name: "IX_Stonks_SecMainConId",
                table: "Stonks",
                column: "SecMainConId");

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
                name: "IX_Wrights_SecIndConId",
                table: "Wrights",
                column: "SecIndConId");

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
                name: "DateSecurity");

            migrationBuilder.DropTable(
                name: "DateSecurityInd");

            migrationBuilder.DropTable(
                name: "DateSecuritySub");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SecurityInds");

            migrationBuilder.DropTable(
                name: "Dates");

            migrationBuilder.DropTable(
                name: "SecuritySubs");

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
                name: "Abligations");

            migrationBuilder.DropTable(
                name: "SecSubCons");

            migrationBuilder.DropTable(
                name: "Stonks");

            migrationBuilder.DropTable(
                name: "Indastrials");

            migrationBuilder.DropTable(
                name: "SecIndCons");

            migrationBuilder.DropTable(
                name: "Securities");

            migrationBuilder.DropTable(
                name: "SecMainCons");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
