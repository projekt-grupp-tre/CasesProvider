﻿// <auto-generated />
using System;
using CasesProvider.Api.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CasesProvider.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241104094928_UpdatedEntities")]
    partial class UpdatedEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CaseCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CaseCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"),
                            CategoryName = "Order",
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6060)
                        },
                        new
                        {
                            Id = new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"),
                            CategoryName = "Account",
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6070)
                        },
                        new
                        {
                            Id = new Guid("25e8f56d-f04b-4df4-a21a-2feca0e1b96e"),
                            CategoryName = "Product",
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6070)
                        });
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CaseStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CaseStatus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a49907f-67e7-4c9e-bc2b-b32e5c77697b"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5700),
                            StatusName = "NotOpened"
                        },
                        new
                        {
                            Id = new Guid("39bf4ccb-1401-4a4f-b7b7-c9b2c8529857"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5740),
                            StatusName = "Opened"
                        },
                        new
                        {
                            Id = new Guid("8ce45e68-15ba-4707-8456-df93bc2c7992"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5800),
                            StatusName = "Closed"
                        },
                        new
                        {
                            Id = new Guid("d1fa62a4-2655-439f-9c5f-6ec667adde73"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5800),
                            StatusName = "Reopened"
                        });
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CaseSubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ParentCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("CaseSubCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e352a9c4-3fed-4e5d-a613-2243d783c5cd"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6120),
                            ParentCategoryId = new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"),
                            SubCategoryName = "Payment_issues"
                        },
                        new
                        {
                            Id = new Guid("87e45066-fdc4-4de3-be56-88349167e9d3"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6140),
                            ParentCategoryId = new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"),
                            SubCategoryName = "Refund_problems"
                        },
                        new
                        {
                            Id = new Guid("8511e1f3-f2c8-433a-86b9-b021f2502b3d"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150),
                            ParentCategoryId = new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"),
                            SubCategoryName = "Billing_discrepancies"
                        },
                        new
                        {
                            Id = new Guid("c3dff7d7-86f6-4b33-b574-8e266f5620ef"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150),
                            ParentCategoryId = new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"),
                            SubCategoryName = "Shipping_issues"
                        },
                        new
                        {
                            Id = new Guid("e3130766-48c6-4b1e-8229-8a825d5ae0d5"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150),
                            ParentCategoryId = new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"),
                            SubCategoryName = "Order_cancellation"
                        },
                        new
                        {
                            Id = new Guid("0e549793-3905-46b2-a941-6f376cf6cbb7"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150),
                            ParentCategoryId = new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"),
                            SubCategoryName = "Return_ticket"
                        },
                        new
                        {
                            Id = new Guid("cdf87045-82a4-4fd2-9e87-518cfb528475"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6160),
                            ParentCategoryId = new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"),
                            SubCategoryName = "Login"
                        },
                        new
                        {
                            Id = new Guid("adf7c1f1-62eb-4780-a9a3-2d30a09d9399"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6160),
                            ParentCategoryId = new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"),
                            SubCategoryName = "Password"
                        },
                        new
                        {
                            Id = new Guid("e91e43c4-62ae-436e-ad52-d018c97cbf58"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6160),
                            ParentCategoryId = new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"),
                            SubCategoryName = "Verification"
                        },
                        new
                        {
                            Id = new Guid("53963637-7ed6-4abf-89df-1f04c98f08f4"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170),
                            ParentCategoryId = new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"),
                            SubCategoryName = "Profile"
                        },
                        new
                        {
                            Id = new Guid("5e287196-126f-435b-aa26-45d9e8314335"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170),
                            ParentCategoryId = new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"),
                            SubCategoryName = "Security"
                        },
                        new
                        {
                            Id = new Guid("7fe758e1-8c80-4966-b2db-b121cc6e9591"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170),
                            ParentCategoryId = new Guid("25e8f56d-f04b-4df4-a21a-2feca0e1b96e"),
                            SubCategoryName = "Product_defect"
                        },
                        new
                        {
                            Id = new Guid("7e11b7e1-f250-4c63-b2c4-0a1f4643cc2a"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170),
                            ParentCategoryId = new Guid("25e8f56d-f04b-4df4-a21a-2feca0e1b96e"),
                            SubCategoryName = "Stock"
                        });
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CommunicationType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CommunicationTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e583848e-0f9b-453c-b6d0-846595cdf331"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6040),
                            Name = "Chat"
                        },
                        new
                        {
                            Id = new Guid("04f0aafb-259c-4e3c-89c4-ccaaf7a536ed"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6050),
                            Name = "Mail"
                        },
                        new
                        {
                            Id = new Guid("df681a75-de13-48a4-8f51-a0cbae08f79d"),
                            CreatedAt = new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6050),
                            Name = "Voice_Video"
                        });
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.SupportCase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AssignedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CaseCoOwnertUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CaseOwnerUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CaseStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CommunicationTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CustomerUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ReopenedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CaseOwnerUserId");

                    b.HasIndex("CaseStatusId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CommunicationTypeId");

                    b.HasIndex("CustomerUserId");

                    b.ToTable("SupportCases");
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CaseSubCategory", b =>
                {
                    b.HasOne("CasesProvider.Api.Data.Entities.CaseCategory", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.SupportCase", b =>
                {
                    b.HasOne("CasesProvider.Api.Data.Entities.User", "CaseOwnerUser")
                        .WithMany("OwnedCases")
                        .HasForeignKey("CaseOwnerUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CasesProvider.Api.Data.Entities.CaseStatus", "CaseStatus")
                        .WithMany("SupportCases")
                        .HasForeignKey("CaseStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CasesProvider.Api.Data.Entities.CaseCategory", "Category")
                        .WithMany("SupportCases")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CasesProvider.Api.Data.Entities.CommunicationType", "CommunicationType")
                        .WithMany("SupportCases")
                        .HasForeignKey("CommunicationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CasesProvider.Api.Data.Entities.User", "CustomerUser")
                        .WithMany("CustomerCases")
                        .HasForeignKey("CustomerUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CaseOwnerUser");

                    b.Navigation("CaseStatus");

                    b.Navigation("Category");

                    b.Navigation("CommunicationType");

                    b.Navigation("CustomerUser");
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CaseCategory", b =>
                {
                    b.Navigation("SubCategories");

                    b.Navigation("SupportCases");
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CaseStatus", b =>
                {
                    b.Navigation("SupportCases");
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.CommunicationType", b =>
                {
                    b.Navigation("SupportCases");
                });

            modelBuilder.Entity("CasesProvider.Api.Data.Entities.User", b =>
                {
                    b.Navigation("CustomerCases");

                    b.Navigation("OwnedCases");
                });
#pragma warning restore 612, 618
        }
    }
}