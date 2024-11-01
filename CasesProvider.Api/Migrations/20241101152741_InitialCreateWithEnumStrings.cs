using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasesProvider.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWithEnumStrings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("2f96ed1b-749f-45bd-a754-f3b02728133c"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("43d393fa-7461-4e36-a4ea-c1fdfa47b690"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("b9fd4ff7-ff83-4c5f-8f65-dc7b78a5ca3e"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("c167f95a-f15c-4544-9acc-d36fe3724302"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1220a46e-68c9-4141-b9a4-f11804da5881"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("226374e7-29c0-4f83-bf96-0ceaf9f61304"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3553dffa-3e91-4097-9469-da275f12cb3e"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f0e130c-2e76-4c16-b1ab-331452e18b0d"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("82bb400d-6f93-47fc-9b3d-b533a78a4c0b"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9efb331e-0c03-4983-96de-256cb81b68c6"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0e1d419-bfdf-4e8e-b4d8-a7abefb61815"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bcb4c0f0-00d0-4526-a220-cbbfc6122420"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c401403e-deb8-4ab4-8d22-bad44bb57e34"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("df328cbd-35b8-4eb8-a646-6dbfe7f393fe"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e95dea58-5926-461e-a216-c70666145241"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f40dccc8-0ff6-4c9c-bc3e-a7ae545d3009"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8a45634-68d3-4ddd-820c-8b2ddae6622d"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("4b29e839-8704-4504-9995-4198b8ff2b63"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("7f9113aa-8794-4be8-99cc-8b0906841741"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("94ed9fa1-9390-4387-bf70-6e0f72d3efd1"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("0972c946-9287-4e06-bb3c-ee93870ffa95"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3945bba-c0e7-48c1-9d67-90d41fb1108d"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea83b86a-391f-4d4d-961c-9927f420a8b9"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CommunicationTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "CaseStatus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "CaseCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "CaseCategories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("175dd190-6c09-4250-8b3a-79508dcb4809"), "Product", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5190) },
                    { new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"), "Order", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5180) },
                    { new Guid("a396f3bb-bff4-4848-882c-00139b7ad9bf"), "Account", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5190) }
                });

            migrationBuilder.InsertData(
                table: "CaseStatus",
                columns: new[] { "Id", "CreatedAt", "StatusName" },
                values: new object[,]
                {
                    { new Guid("9125a6e3-a9b6-45ce-9e8a-2bb38d8b394b"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(4910), "Opened" },
                    { new Guid("94a71f03-da7b-49fe-bda2-81c663ca2b47"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(4920), "Closed" },
                    { new Guid("ab6c0bcb-4fbb-47d1-98f9-a71e2e1dea45"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(4920), "Reopened" },
                    { new Guid("f3afa4f3-0f56-405a-8dbf-994ad7453c8a"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(4870), "NotOpened" }
                });

            migrationBuilder.InsertData(
                table: "CommunicationTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("51682c0b-0e5a-44db-9b5a-09083673957d"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5170), "Chat" },
                    { new Guid("9796be22-6a60-43e4-9f8b-d89354ee8fce"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5170), "Voice_Video" },
                    { new Guid("9fa8de15-679b-4db5-8b38-d1e89207c180"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5170), "Mail" }
                });

            migrationBuilder.InsertData(
                table: "CaseSubCategories",
                columns: new[] { "Id", "CreatedAt", "ParentCategoryId", "SubCategoryName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06ba3355-6c7c-4d3c-8e4a-8037e9982869"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5490), new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"), "Payment_issues", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5470) },
                    { new Guid("0cfdcec6-be49-4322-b504-6fde76e141cc"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5550), new Guid("175dd190-6c09-4250-8b3a-79508dcb4809"), "Product_defect", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5540) },
                    { new Guid("23bec84a-41d2-4425-8516-86cf6ef3328b"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5530), new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"), "Return_ticket", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5520) },
                    { new Guid("3fb2c9ba-bf51-4726-9168-61e44e58bbab"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5530), new Guid("a396f3bb-bff4-4848-882c-00139b7ad9bf"), "Login", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5530) },
                    { new Guid("43a6265f-4a93-4cca-96a3-e161af602586"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5520), new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"), "Billing_discrepancies", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5510) },
                    { new Guid("7bf80df8-3369-4e9a-af2c-7d18ae2ea45f"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5510), new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"), "Refund_problems", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5490) },
                    { new Guid("ab880241-8db5-4a84-bf43-d53068dad4bd"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5520), new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"), "Order_cancellation", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5520) },
                    { new Guid("ac654ac8-879c-46fe-98fd-a364656bc64e"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5550), new Guid("175dd190-6c09-4250-8b3a-79508dcb4809"), "Stock", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5550) },
                    { new Guid("b26b59b6-b454-49ca-9670-7acf697a6317"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5530), new Guid("a396f3bb-bff4-4848-882c-00139b7ad9bf"), "Password", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5530) },
                    { new Guid("cfc70c25-164d-43f2-a36e-b2e3fa711753"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5540), new Guid("a396f3bb-bff4-4848-882c-00139b7ad9bf"), "Profile", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5540) },
                    { new Guid("d307f5a3-6407-420a-8baf-434f13761b5c"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5520), new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"), "Shipping_issues", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5520) },
                    { new Guid("d433667f-3a49-4044-b7f3-d6fce5367627"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5540), new Guid("a396f3bb-bff4-4848-882c-00139b7ad9bf"), "Verification", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5540) },
                    { new Guid("ddc4c33a-46af-4b59-9703-f2927c7e49c9"), new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5540), new Guid("a396f3bb-bff4-4848-882c-00139b7ad9bf"), "Security", new DateTime(2024, 11, 1, 15, 27, 40, 876, DateTimeKind.Utc).AddTicks(5540) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("9125a6e3-a9b6-45ce-9e8a-2bb38d8b394b"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("94a71f03-da7b-49fe-bda2-81c663ca2b47"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("ab6c0bcb-4fbb-47d1-98f9-a71e2e1dea45"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("f3afa4f3-0f56-405a-8dbf-994ad7453c8a"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("06ba3355-6c7c-4d3c-8e4a-8037e9982869"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cfdcec6-be49-4322-b504-6fde76e141cc"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("23bec84a-41d2-4425-8516-86cf6ef3328b"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fb2c9ba-bf51-4726-9168-61e44e58bbab"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("43a6265f-4a93-4cca-96a3-e161af602586"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bf80df8-3369-4e9a-af2c-7d18ae2ea45f"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab880241-8db5-4a84-bf43-d53068dad4bd"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac654ac8-879c-46fe-98fd-a364656bc64e"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b26b59b6-b454-49ca-9670-7acf697a6317"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfc70c25-164d-43f2-a36e-b2e3fa711753"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d307f5a3-6407-420a-8baf-434f13761b5c"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d433667f-3a49-4044-b7f3-d6fce5367627"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ddc4c33a-46af-4b59-9703-f2927c7e49c9"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("51682c0b-0e5a-44db-9b5a-09083673957d"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("9796be22-6a60-43e4-9f8b-d89354ee8fce"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("9fa8de15-679b-4db5-8b38-d1e89207c180"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("175dd190-6c09-4250-8b3a-79508dcb4809"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("30f7b87b-ffab-4f2d-8663-0d33b89f91a3"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("a396f3bb-bff4-4848-882c-00139b7ad9bf"));

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "CommunicationTypes",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "StatusName",
                table: "CaseStatus",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "CaseCategories",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
        }
    }
}
