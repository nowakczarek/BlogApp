using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class FixImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "245a1ba2-94af-44c3-9e22-5530268de966", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b58018e-7b45-40f1-b013-028433b5e1e6", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "245a1ba2-94af-44c3-9e22-5530268de966");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b58018e-7b45-40f1-b013-028433b5e1e6");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "WebPosts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25337307-e734-40d2-93ab-b9385095f606", null, "admin", "admin" },
                    { "3daf4fa5-071f-4383-948b-2f42b7aa9819", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5c34909-edae-46ad-a021-002900c50729", new DateTime(2024, 10, 7, 19, 23, 53, 724, DateTimeKind.Local).AddTicks(8711), "AQAAAAIAAYagAAAAEPQMW+slLkycZmwjQIrhjJi6WxQhY78hxs6V3rZoG474ElAEHXTRNR7Y4MIfPIzohA==", "59a49338-1a0f-4307-b516-3366fd06490b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d6d59a2-cc28-493b-af52-821b556edfcc", new DateTime(2024, 10, 7, 19, 23, 53, 796, DateTimeKind.Local).AddTicks(8133), "AQAAAAIAAYagAAAAEIt7OUBSuw1UCz15rzpXOiSx59pA3s2vq4zyYyMnnAizo3bEjD+yO34g+q8tot/NNg==", "62db570f-a686-4332-8d0e-938fb5d1ae38" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "25337307-e734-40d2-93ab-b9385095f606", "1" },
                    { "3daf4fa5-071f-4383-948b-2f42b7aa9819", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25337307-e734-40d2-93ab-b9385095f606", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3daf4fa5-071f-4383-948b-2f42b7aa9819", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25337307-e734-40d2-93ab-b9385095f606");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3daf4fa5-071f-4383-948b-2f42b7aa9819");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "WebPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "245a1ba2-94af-44c3-9e22-5530268de966", null, "admin", "admin" },
                    { "3b58018e-7b45-40f1-b013-028433b5e1e6", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "714695cc-9f67-4c77-9526-882db12a0a09", new DateTime(2024, 10, 7, 19, 21, 55, 914, DateTimeKind.Local).AddTicks(3301), "AQAAAAIAAYagAAAAEJwipgi5zKmx/UeATRy1x+LFh2F6IwwxC5g+Oim6ElVzq62wlgHTRuK/tN2ehJhtdw==", "58443b0e-e714-48d9-8945-52e2b5a6237a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d4f0dd5-517b-4e77-b72c-45594ea8e3bb", new DateTime(2024, 10, 7, 19, 21, 55, 984, DateTimeKind.Local).AddTicks(2700), "AQAAAAIAAYagAAAAEHYuVb5Bj9fKTwrHnm/KdZLdXS/hoKO+hHw22j/iNZ3uZaOID5zXwpVb2MxzPwfjfQ==", "a71cdfe6-21aa-420a-ba1e-eef6b8d39af3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "245a1ba2-94af-44c3-9e22-5530268de966", "1" },
                    { "3b58018e-7b45-40f1-b013-028433b5e1e6", "2" }
                });
        }
    }
}
