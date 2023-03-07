using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobra.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("357479d0-4f5e-465f-b363-c619efab3dc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lionel", "Messi" },
                    { new Guid("8aa3a21c-b01d-4cfd-942d-00ea91eb6707"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicolas", "Garcia" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "DateCreated", "DateUpdated", "Description", "Name", "ProductId" },
                values: new object[] { new Guid("5cccb1e5-78fa-4a10-a610-2beb8d299179"), "Electro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Led", "TV", "1112222333" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "DateCreated", "DateUpdated", "MartialStatus", "Occupation", "PersonId" },
                values: new object[] { new Guid("706304cf-188a-41c0-ba7c-410fa6cb7fbf"), 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Married", "Software Developer", new Guid("8aa3a21c-b01d-4cfd-942d-00ea91eb6707") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "MethodPurchase", "PersonId" },
                values: new object[] { new Guid("e3307314-123c-468b-b6b7-895436cf9983"), new DateTime(2023, 2, 5, 11, 28, 20, 325, DateTimeKind.Local).AddTicks(1718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WebPage", new Guid("8aa3a21c-b01d-4cfd-942d-00ea91eb6707") });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "OrderId", "OrderNumber", "ProductId", "ProductOrigin" },
                values: new object[] { new Guid("65607b71-7945-47b4-b82a-95a0d47ad167"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3307314-123c-468b-b6b7-895436cf9983"), 1, new Guid("5cccb1e5-78fa-4a10-a610-2beb8d299179"), "China" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("706304cf-188a-41c0-ba7c-410fa6cb7fbf"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("65607b71-7945-47b4-b82a-95a0d47ad167"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("357479d0-4f5e-465f-b363-c619efab3dc6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e3307314-123c-468b-b6b7-895436cf9983"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cccb1e5-78fa-4a10-a610-2beb8d299179"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8aa3a21c-b01d-4cfd-942d-00ea91eb6707"));
        }
    }
}
