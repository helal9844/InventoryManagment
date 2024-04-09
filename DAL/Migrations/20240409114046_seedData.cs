using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Catagory", "CreatedDate", "DeletedDate", "Description", "IsDeleted", "ItemName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Category 1", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6148), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6134), "Description 1", false, "Item 1", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6149) },
                    { 2, "Category 2", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6158), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6154), "Description 2", false, "Item 2", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6159) },
                    { 3, "Category 3", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6164), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6160), "Description 3", false, "Item 3", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6165) },
                    { 4, "Category 4", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6166), "Description 4", false, "Item 4", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6171) },
                    { 5, "Category 5", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6176), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6172), "Description 5", false, "Item 5", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6177) },
                    { 6, "Category 6", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6184), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6180), "Description 6", false, "Item 6", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6184) },
                    { 7, "Category 7", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6186), "Description 7", false, "Item 7", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6190) },
                    { 8, "Category 8", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6192), "Description 8", false, "Item 8", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6197) },
                    { 9, "Category 9", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6199), "Description 9", false, "Item 9", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6203) },
                    { 10, "Category 10", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6206), "Description 10", false, "Item 10", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6212) }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "ContactInformation", "CreatedDate", "DeletedDate", "IsDeleted", "StoreLocation", "StoreName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Contact Info 1", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5769), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5721), false, "Location 1", "Store 1", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5770) },
                    { 2, "Contact Info 2", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5779), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5775), false, "Location 2", "Store 2", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5780) },
                    { 3, "Contact Info 3", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5786), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5782), false, "Location 3", "Store 3", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5786) },
                    { 4, "Contact Info 4", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5788), false, "Location 4", "Store 4", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5793) },
                    { 5, "Contact Info 5", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5795), false, "Location 5", "Store 5", new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5799) }
                });

            migrationBuilder.InsertData(
                table: "StoreItems",
                columns: new[] { "ItemId", "StoreId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 27.65m, 97 },
                    { 2, 1, 43.94m, 49 },
                    { 3, 1, 8.20m, 51 },
                    { 4, 1, 9.01m, 9 },
                    { 5, 1, 53.82m, 10 },
                    { 6, 1, 46.59m, 55 },
                    { 7, 1, 52.36m, 76 },
                    { 8, 1, 33.19m, 72 },
                    { 9, 1, 70.33m, 90 },
                    { 10, 1, 34.59m, 53 },
                    { 1, 2, 24.16m, 49 },
                    { 2, 2, 59.25m, 2 },
                    { 3, 2, 47.24m, 87 },
                    { 4, 2, 56.65m, 37 },
                    { 5, 2, 86.20m, 63 },
                    { 6, 2, 27.09m, 88 },
                    { 7, 2, 79.51m, 86 },
                    { 8, 2, 21.00m, 53 },
                    { 9, 2, 25.15m, 71 },
                    { 10, 2, 97.80m, 59 },
                    { 1, 3, 43.57m, 91 },
                    { 2, 3, 50.97m, 88 },
                    { 3, 3, 44.11m, 67 },
                    { 4, 3, 75.73m, 81 },
                    { 5, 3, 58.53m, 85 },
                    { 6, 3, 5.94m, 94 },
                    { 7, 3, 90.46m, 77 },
                    { 8, 3, 7.90m, 18 },
                    { 9, 3, 91.98m, 90 },
                    { 10, 3, 41.06m, 43 },
                    { 1, 4, 10.39m, 69 },
                    { 2, 4, 46.56m, 70 },
                    { 3, 4, 82.93m, 75 },
                    { 4, 4, 44.62m, 95 },
                    { 5, 4, 78.26m, 7 },
                    { 6, 4, 66.61m, 11 },
                    { 7, 4, 22.95m, 74 },
                    { 8, 4, 65.27m, 51 },
                    { 9, 4, 40.32m, 13 },
                    { 10, 4, 12.99m, 44 },
                    { 1, 5, 91.59m, 80 },
                    { 2, 5, 87.87m, 39 },
                    { 3, 5, 97.02m, 8 },
                    { 4, 5, 15.40m, 1 },
                    { 5, 5, 66.43m, 46 },
                    { 6, 5, 35.16m, 54 },
                    { 7, 5, 39.44m, 6 },
                    { 8, 5, 72.39m, 10 },
                    { 9, 5, 82.57m, 36 },
                    { 10, 5, 51.07m, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
