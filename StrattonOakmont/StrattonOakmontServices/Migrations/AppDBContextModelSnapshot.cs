﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StrattonOakmontServices;

namespace StrattonOakmontServices.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("StrattonOakmontModels.Security", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategorySecId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyIMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanySecId")
                        .HasColumnType("int");

                    b.Property<int>("PerSent")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorySecId");

                    b.HasIndex("CompanySecId");

                    b.ToTable("Securities");
                });

            modelBuilder.Entity("StrattonOakmontModels.Security", b =>
                {
                    b.HasOne("StrattonOakmontModels.Category", "CategorySec")
                        .WithMany("Securities")
                        .HasForeignKey("CategorySecId");

                    b.HasOne("StrattonOakmontModels.Company", "CompanySec")
                        .WithMany("Securities")
                        .HasForeignKey("CompanySecId");

                    b.Navigation("CategorySec");

                    b.Navigation("CompanySec");
                });

            modelBuilder.Entity("StrattonOakmontModels.Category", b =>
                {
                    b.Navigation("Securities");
                });

            modelBuilder.Entity("StrattonOakmontModels.Company", b =>
                {
                    b.Navigation("Securities");
                });
#pragma warning restore 612, 618
        }
    }
}
