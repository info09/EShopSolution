using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopSolution.Data.Migrations
{
    public partial class Add_SeedData_Identity_20200310_ver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 10, 0, 31, 13, 235, DateTimeKind.Local).AddTicks(1144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 10, 0, 28, 1, 598, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "aa906ae6-45e9-4204-b9aa-a861fa60926a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "ecebd4dd-e499-49cf-bd74-76edfb56cdec", "huytq3103@gmail.com", "Huy", "Tran", "huytq3103@gmail.com", "AQAAAAEAACcQAAAAEJ2IQ1t8gDIft10AD9Zvlna5mUv1xhCPRkfKSIyhyegOPv1vHS8s0W6fdrcflNvFFA==" });

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
                value: new DateTime(2020, 3, 10, 0, 31, 13, 258, DateTimeKind.Local).AddTicks(6598));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 10, 0, 28, 1, 598, DateTimeKind.Local).AddTicks(8902),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 10, 0, 31, 13, 235, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b004f0a3-8853-43cb-bcca-3bbc83bf9570");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "98bf9c71-40a4-4e49-a55c-014d7b9cbb2a", "tedu.international@gmail.com", "Toan", "Bach", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEGsdX5MYJRcxTVfcqA76yIRGPxbkcXFP+aAbcb1AUvdJIqcn8dKrQ+zIEMWi9PC7wg==" });

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
                value: new DateTime(2020, 3, 10, 0, 28, 1, 624, DateTimeKind.Local).AddTicks(7666));
        }
    }
}
