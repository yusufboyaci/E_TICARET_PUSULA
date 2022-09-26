﻿// <auto-generated />
using System;
using DATAACCESS.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DATAACCESS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220926132920_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ENTITIES.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Created AD User Name");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("text")
                        .HasColumnName("Created IP");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Modified AD User Name");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("text")
                        .HasColumnName("Modified IP");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("baskets", (string)null);
                });

            modelBuilder.Entity("ENTITIES.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("BasketId")
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Created AD User Name");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("text")
                        .HasColumnName("Created IP");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Modified AD User Name");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("text")
                        .HasColumnName("Modified IP");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("QuantityPerUnit")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<short?>("Stock")
                        .HasColumnType("smallint");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("UserId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("ENTITIES.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Created AD User Name");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("text")
                        .HasColumnName("Created IP");

                    b.Property<string>("MailAddress")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Modified AD User Name");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("text")
                        .HasColumnName("Modified IP");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("Role")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("UserImagePath")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("ENTITIES.Product", b =>
                {
                    b.HasOne("ENTITIES.Basket", "Basket")
                        .WithMany("Products")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENTITIES.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ENTITIES.Basket", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ENTITIES.User", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}