﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StrattonOakmontServices;

namespace StrattonOakmontServices.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20211124155045_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DateSecurity", b =>
                {
                    b.Property<int>("DateTimesChangesId")
                        .HasColumnType("int");

                    b.Property<int>("SecuritiesId")
                        .HasColumnType("int");

                    b.HasKey("DateTimesChangesId", "SecuritiesId");

                    b.HasIndex("SecuritiesId");

                    b.ToTable("DateSecurity");
                });

            modelBuilder.Entity("DateSecurityInd", b =>
                {
                    b.Property<int>("DateTimesChangesId")
                        .HasColumnType("int");

                    b.Property<int>("SecurityIndId")
                        .HasColumnType("int");

                    b.HasKey("DateTimesChangesId", "SecurityIndId");

                    b.HasIndex("SecurityIndId");

                    b.ToTable("DateSecurityInd");
                });

            modelBuilder.Entity("DateSecuritySub", b =>
                {
                    b.Property<int>("DateTimesChangesId")
                        .HasColumnType("int");

                    b.Property<int>("SecuritySubsId")
                        .HasColumnType("int");

                    b.HasKey("DateTimesChangesId", "SecuritySubsId");

                    b.HasIndex("SecuritySubsId");

                    b.ToTable("DateSecuritySub");
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StrattonOakmontModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("StrattonOakmontModels.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Сapitalization")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("StrattonOakmontModels.Date", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("StrattonOakmontModels.Indastrial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Indastrials");
                });

            modelBuilder.Entity("StrattonOakmontModels.Security", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CategorySecId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanySecId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("UserSecId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorySecId");

                    b.HasIndex("CompanySecId");

                    b.HasIndex("UserSecId");

                    b.ToTable("Securities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Security");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.SecurityInd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategorySecId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("UserSecId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategorySecId");

                    b.HasIndex("UserSecId");

                    b.ToTable("SecurityInds");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SecurityInd");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Type.SecuritySub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategorySecId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LifeCycle")
                        .HasColumnType("int");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("UserSecId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategorySecId");

                    b.HasIndex("UserSecId");

                    b.ToTable("SecuritySubs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SecuritySub");
                });

            modelBuilder.Entity("StrattonOakmontModels.User", b =>
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

                    b.Property<string>("Img")
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

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("StrattonOakmontModels.Abligation", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Security");

                    b.Property<string>("FinalTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Abligation");
                });

            modelBuilder.Entity("StrattonOakmontModels.Stonk", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Security");

                    b.Property<bool>("Divisibility")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Stonk");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Forward", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Securityes.SecurityInd");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Forward_Active");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("int")
                        .HasColumnName("Forward_FinalPrice");

                    b.Property<string>("FinalTime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Forward_FinalTime");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Forward_IMG");

                    b.Property<int?>("IndastrialSecId")
                        .HasColumnType("int")
                        .HasColumnName("Forward_IndastrialSecId");

                    b.Property<string>("NameIndastry")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Forward_NameIndastry");

                    b.HasIndex("IndastrialSecId");

                    b.HasDiscriminator().HasValue("Forward");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Futures", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Securityes.SecurityInd");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Futures_Active");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("int")
                        .HasColumnName("Futures_FinalPrice");

                    b.Property<string>("FinalTime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Futures_FinalTime");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Futures_IMG");

                    b.Property<int?>("IndastrialSecId")
                        .HasColumnType("int")
                        .HasColumnName("Futures_IndastrialSecId");

                    b.Property<string>("NameIndastry")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Futures_NameIndastry");

                    b.HasIndex("IndastrialSecId");

                    b.HasDiscriminator().HasValue("Futures");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Option", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Securityes.SecurityInd");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("int");

                    b.Property<string>("FinalTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IndastrialSecId")
                        .HasColumnType("int");

                    b.Property<string>("NameIndastry")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("IndastrialSecId");

                    b.HasDiscriminator().HasValue("Option");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Wright", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Securityes.SecurityInd");

                    b.Property<int?>("ActiveId")
                        .HasColumnType("int");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("int")
                        .HasColumnName("Wright_FinalPrice");

                    b.Property<string>("FinalTime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Wright_FinalTime");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Wright_IMG");

                    b.Property<int?>("IndastrialSecId")
                        .HasColumnType("int")
                        .HasColumnName("Wright_IndastrialSecId");

                    b.Property<string>("NameIndastry")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Wright_NameIndastry");

                    b.HasIndex("ActiveId");

                    b.HasIndex("IndastrialSecId");

                    b.HasDiscriminator().HasValue("Wright");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Bill", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Securityes.Type.SecuritySub");

                    b.Property<string>("FinalTime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Bill_FinalTime");

                    b.Property<string>("Getter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Bill_IMG");

                    b.Property<string>("PerSent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setter")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Bill");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.DepositReceipts", b =>
                {
                    b.HasBaseType("StrattonOakmontModels.Securityes.Type.SecuritySub");

                    b.Property<int?>("AbligationId")
                        .HasColumnType("int");

                    b.Property<string>("FinalTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StonkId")
                        .HasColumnType("int");

                    b.HasIndex("AbligationId");

                    b.HasIndex("StonkId");

                    b.HasDiscriminator().HasValue("DepositReceipts");
                });

            modelBuilder.Entity("DateSecurity", b =>
                {
                    b.HasOne("StrattonOakmontModels.Date", null)
                        .WithMany()
                        .HasForeignKey("DateTimesChangesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StrattonOakmontModels.Security", null)
                        .WithMany()
                        .HasForeignKey("SecuritiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DateSecurityInd", b =>
                {
                    b.HasOne("StrattonOakmontModels.Date", null)
                        .WithMany()
                        .HasForeignKey("DateTimesChangesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StrattonOakmontModels.Securityes.SecurityInd", null)
                        .WithMany()
                        .HasForeignKey("SecurityIndId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DateSecuritySub", b =>
                {
                    b.HasOne("StrattonOakmontModels.Date", null)
                        .WithMany()
                        .HasForeignKey("DateTimesChangesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StrattonOakmontModels.Securityes.Type.SecuritySub", null)
                        .WithMany()
                        .HasForeignKey("SecuritySubsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("StrattonOakmontModels.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StrattonOakmontModels.User", null)
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

                    b.HasOne("StrattonOakmontModels.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StrattonOakmontModels.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StrattonOakmontModels.Security", b =>
                {
                    b.HasOne("StrattonOakmontModels.Category", "CategorySec")
                        .WithMany("Securities")
                        .HasForeignKey("CategorySecId");

                    b.HasOne("StrattonOakmontModels.Company", "CompanySec")
                        .WithMany("Securities")
                        .HasForeignKey("CompanySecId");

                    b.HasOne("StrattonOakmontModels.User", "UserSec")
                        .WithMany("Securities")
                        .HasForeignKey("UserSecId");

                    b.Navigation("CategorySec");

                    b.Navigation("CompanySec");

                    b.Navigation("UserSec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.SecurityInd", b =>
                {
                    b.HasOne("StrattonOakmontModels.Category", "CategorySec")
                        .WithMany("SecuritiesInd")
                        .HasForeignKey("CategorySecId");

                    b.HasOne("StrattonOakmontModels.User", "UserSec")
                        .WithMany()
                        .HasForeignKey("UserSecId");

                    b.Navigation("CategorySec");

                    b.Navigation("UserSec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Type.SecuritySub", b =>
                {
                    b.HasOne("StrattonOakmontModels.Category", "CategorySec")
                        .WithMany("SecuritiesSub")
                        .HasForeignKey("CategorySecId");

                    b.HasOne("StrattonOakmontModels.User", "UserSec")
                        .WithMany()
                        .HasForeignKey("UserSecId");

                    b.Navigation("CategorySec");

                    b.Navigation("UserSec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Forward", b =>
                {
                    b.HasOne("StrattonOakmontModels.Indastrial", "IndastrialSec")
                        .WithMany("Forwards")
                        .HasForeignKey("IndastrialSecId");

                    b.Navigation("IndastrialSec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Futures", b =>
                {
                    b.HasOne("StrattonOakmontModels.Indastrial", "IndastrialSec")
                        .WithMany("Futures")
                        .HasForeignKey("IndastrialSecId");

                    b.Navigation("IndastrialSec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Option", b =>
                {
                    b.HasOne("StrattonOakmontModels.Indastrial", "IndastrialSec")
                        .WithMany("Options")
                        .HasForeignKey("IndastrialSecId");

                    b.Navigation("IndastrialSec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.Wright", b =>
                {
                    b.HasOne("StrattonOakmontModels.Security", "Active")
                        .WithMany()
                        .HasForeignKey("ActiveId");

                    b.HasOne("StrattonOakmontModels.Indastrial", "IndastrialSec")
                        .WithMany("Wrights")
                        .HasForeignKey("IndastrialSecId");

                    b.Navigation("Active");

                    b.Navigation("IndastrialSec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Securityes.DepositReceipts", b =>
                {
                    b.HasOne("StrattonOakmontModels.Abligation", "Abligation")
                        .WithMany()
                        .HasForeignKey("AbligationId");

                    b.HasOne("StrattonOakmontModels.Stonk", "Stonk")
                        .WithMany()
                        .HasForeignKey("StonkId");

                    b.Navigation("Abligation");

                    b.Navigation("Stonk");
                });

            modelBuilder.Entity("StrattonOakmontModels.Category", b =>
                {
                    b.Navigation("Securities");

                    b.Navigation("SecuritiesInd");

                    b.Navigation("SecuritiesSub");
                });

            modelBuilder.Entity("StrattonOakmontModels.Company", b =>
                {
                    b.Navigation("Securities");
                });

            modelBuilder.Entity("StrattonOakmontModels.Indastrial", b =>
                {
                    b.Navigation("Forwards");

                    b.Navigation("Futures");

                    b.Navigation("Options");

                    b.Navigation("Wrights");
                });

            modelBuilder.Entity("StrattonOakmontModels.User", b =>
                {
                    b.Navigation("Securities");
                });
#pragma warning restore 612, 618
        }
    }
}
