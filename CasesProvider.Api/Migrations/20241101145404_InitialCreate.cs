using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasesProvider.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusName = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseSubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseSubCategories_CaseCategories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "CaseCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportCases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: true),
                    CustomerUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaseOwnerUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CaseCoOwnertUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CaseStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReopenedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommunicationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportCases_CaseCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CaseCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportCases_CaseStatus_CaseStatusId",
                        column: x => x.CaseStatusId,
                        principalTable: "CaseStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportCases_CommunicationTypes_CommunicationTypeId",
                        column: x => x.CommunicationTypeId,
                        principalTable: "CommunicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportCases_Users_CaseOwnerUserId",
                        column: x => x.CaseOwnerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportCases_Users_CustomerUserId",
                        column: x => x.CustomerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CaseCategories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"), 0, new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7650), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7640) },
                    { new Guid("b3945bba-c0e7-48c1-9d67-90d41fb1108d"), 2, new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7650), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7650) },
                    { new Guid("ea83b86a-391f-4d4d-961c-9927f420a8b9"), 1, new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7650), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7650) }
                });

            migrationBuilder.InsertData(
                table: "CaseStatus",
                columns: new[] { "Id", "CreatedAt", "StatusName" },
                values: new object[,]
                {
                    { new Guid("2f96ed1b-749f-45bd-a754-f3b02728133c"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7380), 0 },
                    { new Guid("43d393fa-7461-4e36-a4ea-c1fdfa47b690"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7410), 3 },
                    { new Guid("b9fd4ff7-ff83-4c5f-8f65-dc7b78a5ca3e"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7410), 2 },
                    { new Guid("c167f95a-f15c-4544-9acc-d36fe3724302"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7400), 1 }
                });

            migrationBuilder.InsertData(
                table: "CommunicationTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("4b29e839-8704-4504-9995-4198b8ff2b63"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7630), 1 },
                    { new Guid("7f9113aa-8794-4be8-99cc-8b0906841741"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7630), 2 },
                    { new Guid("94ed9fa1-9390-4387-bf70-6e0f72d3efd1"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7620), 0 }
                });

            migrationBuilder.InsertData(
                table: "CaseSubCategories",
                columns: new[] { "Id", "CreatedAt", "ParentCategoryId", "SubCategoryName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1220a46e-68c9-4141-b9a4-f11804da5881"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7730), new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"), "Order_cancellation", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7730) },
                    { new Guid("226374e7-29c0-4f83-bf96-0ceaf9f61304"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7700), new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"), "Payment_issues", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7700) },
                    { new Guid("3553dffa-3e91-4097-9469-da275f12cb3e"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7740), new Guid("ea83b86a-391f-4d4d-961c-9927f420a8b9"), "Login", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7740) },
                    { new Guid("3f0e130c-2e76-4c16-b1ab-331452e18b0d"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7760), new Guid("b3945bba-c0e7-48c1-9d67-90d41fb1108d"), "Stock", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7760) },
                    { new Guid("82bb400d-6f93-47fc-9b3d-b533a78a4c0b"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7720), new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"), "Refund_problems", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7700) },
                    { new Guid("9efb331e-0c03-4983-96de-256cb81b68c6"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7760), new Guid("b3945bba-c0e7-48c1-9d67-90d41fb1108d"), "Product_defect", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7750) },
                    { new Guid("a0e1d419-bfdf-4e8e-b4d8-a7abefb61815"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7740), new Guid("ea83b86a-391f-4d4d-961c-9927f420a8b9"), "Password", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7740) },
                    { new Guid("bcb4c0f0-00d0-4526-a220-cbbfc6122420"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7730), new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"), "Shipping_issues", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7730) },
                    { new Guid("c401403e-deb8-4ab4-8d22-bad44bb57e34"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7750), new Guid("ea83b86a-391f-4d4d-961c-9927f420a8b9"), "Verification", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7750) },
                    { new Guid("df328cbd-35b8-4eb8-a646-6dbfe7f393fe"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7730), new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"), "Billing_discrepancies", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7730) },
                    { new Guid("e95dea58-5926-461e-a216-c70666145241"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7750), new Guid("ea83b86a-391f-4d4d-961c-9927f420a8b9"), "Security", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7750) },
                    { new Guid("f40dccc8-0ff6-4c9c-bc3e-a7ae545d3009"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7740), new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"), "Return_ticket", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7740) },
                    { new Guid("f8a45634-68d3-4ddd-820c-8b2ddae6622d"), new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7750), new Guid("ea83b86a-391f-4d4d-961c-9927f420a8b9"), "Profile", new DateTime(2024, 11, 1, 14, 54, 3, 290, DateTimeKind.Utc).AddTicks(7750) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseSubCategories_ParentCategoryId",
                table: "CaseSubCategories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_CaseOwnerUserId",
                table: "SupportCases",
                column: "CaseOwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_CaseStatusId",
                table: "SupportCases",
                column: "CaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_CategoryId",
                table: "SupportCases",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_CommunicationTypeId",
                table: "SupportCases",
                column: "CommunicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_CustomerUserId",
                table: "SupportCases",
                column: "CustomerUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseSubCategories");

            migrationBuilder.DropTable(
                name: "SupportCases");

            migrationBuilder.DropTable(
                name: "CaseCategories");

            migrationBuilder.DropTable(
                name: "CaseStatus");

            migrationBuilder.DropTable(
                name: "CommunicationTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
