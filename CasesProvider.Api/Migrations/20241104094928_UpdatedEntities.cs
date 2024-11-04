using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasesProvider.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReopenedAt",
                table: "SupportCases",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedAt",
                table: "SupportCases",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssignedAt",
                table: "SupportCases",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CaseSubCategories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CaseCategories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "CaseCategories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("25e8f56d-f04b-4df4-a21a-2feca0e1b96e"), "Product", new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6070), null },
                    { new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"), "Order", new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6060), null },
                    { new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"), "Account", new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6070), null }
                });

            migrationBuilder.InsertData(
                table: "CaseStatus",
                columns: new[] { "Id", "CreatedAt", "StatusName" },
                values: new object[,]
                {
                    { new Guid("39bf4ccb-1401-4a4f-b7b7-c9b2c8529857"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5740), "Opened" },
                    { new Guid("6a49907f-67e7-4c9e-bc2b-b32e5c77697b"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5700), "NotOpened" },
                    { new Guid("8ce45e68-15ba-4707-8456-df93bc2c7992"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5800), "Closed" },
                    { new Guid("d1fa62a4-2655-439f-9c5f-6ec667adde73"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(5800), "Reopened" }
                });

            migrationBuilder.InsertData(
                table: "CommunicationTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("04f0aafb-259c-4e3c-89c4-ccaaf7a536ed"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6050), "Mail" },
                    { new Guid("df681a75-de13-48a4-8f51-a0cbae08f79d"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6050), "Voice_Video" },
                    { new Guid("e583848e-0f9b-453c-b6d0-846595cdf331"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6040), "Chat" }
                });

            migrationBuilder.InsertData(
                table: "CaseSubCategories",
                columns: new[] { "Id", "CreatedAt", "ParentCategoryId", "SubCategoryName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e549793-3905-46b2-a941-6f376cf6cbb7"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150), new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"), "Return_ticket", null },
                    { new Guid("53963637-7ed6-4abf-89df-1f04c98f08f4"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170), new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"), "Profile", null },
                    { new Guid("5e287196-126f-435b-aa26-45d9e8314335"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170), new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"), "Security", null },
                    { new Guid("7e11b7e1-f250-4c63-b2c4-0a1f4643cc2a"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170), new Guid("25e8f56d-f04b-4df4-a21a-2feca0e1b96e"), "Stock", null },
                    { new Guid("7fe758e1-8c80-4966-b2db-b121cc6e9591"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6170), new Guid("25e8f56d-f04b-4df4-a21a-2feca0e1b96e"), "Product_defect", null },
                    { new Guid("8511e1f3-f2c8-433a-86b9-b021f2502b3d"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150), new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"), "Billing_discrepancies", null },
                    { new Guid("87e45066-fdc4-4de3-be56-88349167e9d3"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6140), new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"), "Refund_problems", null },
                    { new Guid("adf7c1f1-62eb-4780-a9a3-2d30a09d9399"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6160), new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"), "Password", null },
                    { new Guid("c3dff7d7-86f6-4b33-b574-8e266f5620ef"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150), new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"), "Shipping_issues", null },
                    { new Guid("cdf87045-82a4-4fd2-9e87-518cfb528475"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6160), new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"), "Login", null },
                    { new Guid("e3130766-48c6-4b1e-8229-8a825d5ae0d5"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6150), new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"), "Order_cancellation", null },
                    { new Guid("e352a9c4-3fed-4e5d-a613-2243d783c5cd"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6120), new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"), "Payment_issues", null },
                    { new Guid("e91e43c4-62ae-436e-ad52-d018c97cbf58"), new DateTime(2024, 11, 4, 9, 49, 28, 249, DateTimeKind.Utc).AddTicks(6160), new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"), "Verification", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("39bf4ccb-1401-4a4f-b7b7-c9b2c8529857"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("6a49907f-67e7-4c9e-bc2b-b32e5c77697b"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("8ce45e68-15ba-4707-8456-df93bc2c7992"));

            migrationBuilder.DeleteData(
                table: "CaseStatus",
                keyColumn: "Id",
                keyValue: new Guid("d1fa62a4-2655-439f-9c5f-6ec667adde73"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e549793-3905-46b2-a941-6f376cf6cbb7"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("53963637-7ed6-4abf-89df-1f04c98f08f4"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e287196-126f-435b-aa26-45d9e8314335"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e11b7e1-f250-4c63-b2c4-0a1f4643cc2a"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7fe758e1-8c80-4966-b2db-b121cc6e9591"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8511e1f3-f2c8-433a-86b9-b021f2502b3d"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("87e45066-fdc4-4de3-be56-88349167e9d3"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("adf7c1f1-62eb-4780-a9a3-2d30a09d9399"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3dff7d7-86f6-4b33-b574-8e266f5620ef"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cdf87045-82a4-4fd2-9e87-518cfb528475"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3130766-48c6-4b1e-8229-8a825d5ae0d5"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e352a9c4-3fed-4e5d-a613-2243d783c5cd"));

            migrationBuilder.DeleteData(
                table: "CaseSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e91e43c4-62ae-436e-ad52-d018c97cbf58"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("04f0aafb-259c-4e3c-89c4-ccaaf7a536ed"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("df681a75-de13-48a4-8f51-a0cbae08f79d"));

            migrationBuilder.DeleteData(
                table: "CommunicationTypes",
                keyColumn: "Id",
                keyValue: new Guid("e583848e-0f9b-453c-b6d0-846595cdf331"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("25e8f56d-f04b-4df4-a21a-2feca0e1b96e"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b937066-de09-4b8b-806d-9f860c4bb038"));

            migrationBuilder.DeleteData(
                table: "CaseCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa7ab8ee-833d-4ef6-a1eb-50c43284a1f1"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReopenedAt",
                table: "SupportCases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedAt",
                table: "SupportCases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssignedAt",
                table: "SupportCases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CaseSubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CaseCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
