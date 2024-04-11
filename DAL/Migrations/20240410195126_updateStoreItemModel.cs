using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateStoreItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StoreItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "StoreItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StoreItems",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "StoreItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4979), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5012), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5015), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5032), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5043), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5046), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5057), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5078), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5081), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5092), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5095), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5106), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5109), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5124), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5141), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5144), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8525), false, 49.71m, 10, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8600), false, 45.46m, 94, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8616), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8620), false, 23.25m, 29, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8644), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8647), false, 26.67m, 71, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8669), false, 72.58m, 46, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8697), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8700), false, 51.82m, 77, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8720), false, 3.74m, 90, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8742), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8746), false, 4.46m, 22, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8762), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8766), false, 86.46m, 61, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8791), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8794), false, 2.98m, 47, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8812), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8816), false, 28.91m, 56, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8841), false, 38.77m, 51, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8859), false, 65.93m, 62, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8881), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8884), false, 30.43m, 17, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8899), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8903), false, 82.86m, 72, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8924), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8928), false, 7.60m, 7, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8943), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8947), false, 71.37m, 56, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8972), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8976), false, 65.82m, 1, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8991), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8994), false, 22.40m, 6, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9020), false, 21.91m, 92, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9036), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9040), false, 57.79m, 27, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9066), false, 74.95m, 85, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9085), false, 89.74m, 75, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9266), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9270), false, 14.36m, 26, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9290), false, 81.51m, 70, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9313), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9316), false, 84.60m, 26, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9334), false, 91.81m, 35, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9356), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9360), false, 22.22m, 67, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9378), false, 74.32m, 95, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9405), false, 5.15m, 11, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9426), false, 88.83m, 7, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9448), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9451), false, 37.78m, 99, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9467), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9470), false, 64.32m, 40, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9498), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9502), false, 58.87m, 92, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9520), false, 70.88m, 44, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9545), false, 39.70m, 20, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9560), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9564), false, 11.92m, 57, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9586), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9589), false, 78.25m, 38, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9605), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9608), false, 39.45m, 33, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 4 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9634), false, 67.36m, 33, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9650), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9654), false, 66.92m, 57, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9679), false, 65.13m, 54, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9694), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9698), false, 0.92m, 77, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9723), false, 25.80m, 60, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9738), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9742), false, 75.96m, 57, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9764), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9767), false, 6.30m, 7, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9786), false, 61.74m, 71, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9807), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9811), false, 90.47m, 83, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9826), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9829), false, 81.59m, 35, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 5 },
                columns: new[] { "CreatedDate", "DeletedDate", "IsDeleted", "Price", "Quantity", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9851), new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9855), false, 51.51m, 92, new DateTime(2024, 4, 10, 21, 51, 25, 839, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(3968), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4010), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4190), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4207), new DateTime(2024, 4, 10, 21, 51, 25, 838, DateTimeKind.Local).AddTicks(4205) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "StoreItems");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6148), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6134), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6158), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6164), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6166), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6176), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6184), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6186), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6192), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 27.65m, 97 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 43.94m, 49 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 8.20m, 51 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 9.01m, 9 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 53.82m, 10 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 46.59m, 55 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 52.36m, 76 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 33.19m, 72 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 70.33m, 90 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 34.59m, 53 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 24.16m, 49 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 59.25m, 2 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 47.24m, 87 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 56.65m, 37 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 86.20m, 63 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 27.09m, 88 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 79.51m, 86 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 21.00m, 53 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 25.15m, 71 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 97.80m, 59 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 43.57m, 91 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 50.97m, 88 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 44.11m, 67 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 75.73m, 81 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 58.53m, 85 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 5.94m, 94 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 90.46m, 77 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 7.90m, 18 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 91.98m, 90 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 41.06m, 43 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 10.39m, 69 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 46.56m, 70 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 82.93m, 75 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 44.62m, 95 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 78.26m, 7 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 66.61m, 11 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 22.95m, 74 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 65.27m, 51 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 40.32m, 13 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 4 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 12.99m, 44 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 91.59m, 80 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 87.87m, 39 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 97.02m, 8 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 15.40m, 1 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 66.43m, 46 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 35.16m, 54 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 7, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 39.44m, 6 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 8, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 72.39m, 10 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 9, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 82.57m, 36 });

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumns: new[] { "ItemId", "StoreId" },
                keyValues: new object[] { 10, 5 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 51.07m, 15 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5769), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5779), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5786), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 4, 9, 13, 40, 46, 75, DateTimeKind.Local).AddTicks(5799) });
        }
    }
}
