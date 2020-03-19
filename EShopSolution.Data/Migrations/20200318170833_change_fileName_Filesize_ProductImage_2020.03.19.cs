using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopSolution.Data.Migrations
{
    public partial class change_fileName_Filesize_ProductImage_20200319 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 19, 0, 8, 32, 382, DateTimeKind.Local).AddTicks(7799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 18, 23, 19, 59, 992, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "365977aa-99bc-4809-a5eb-4b03e7b16e61");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7c4ea4f-2427-4944-b1ab-9e36f35cb4d0", "AQAAAAEAACcQAAAAEDvrotsONZWtHz7RhrvNzYkck7tzn5RLG/6JL+DqVWw7dYXksRH6z/kM8Xq2jOrIpg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 3, 19, 0, 8, 32, 422, DateTimeKind.Local).AddTicks(9881));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImage",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 18, 23, 19, 59, 992, DateTimeKind.Local).AddTicks(9212),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 19, 0, 8, 32, 382, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "52db2c12-4913-4860-b0ea-a2291e716f0d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b012c454-6d8e-4194-854c-42ea90e5853e", "AQAAAAEAACcQAAAAEBdF3BkQ8qt5w8D20gccV6eLIi19J2Tq6hsvuG624Rn4LzRKUtvioNV2GnLhahfBTA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 3, 18, 23, 20, 0, 64, DateTimeKind.Local).AddTicks(4276));
        }
    }
}
