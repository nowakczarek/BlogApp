using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathToWebPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d413c1e7-864a-41d0-b060-a143cc132c98", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d64b49d1-bb3c-413f-b224-784cdb87dee9", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d413c1e7-864a-41d0-b060-a143cc132c98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64b49d1-bb3c-413f-b224-784cdb87dee9");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "WebPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ec12e3a-867f-4f29-aad9-ec942c18ab5f", null, "client", "client" },
                    { "863ee9bd-8e89-403c-a063-6a335693f788", null, "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28e9e871-c874-4168-bef5-a114d2f900a3", new DateTime(2024, 10, 7, 17, 56, 0, 967, DateTimeKind.Local).AddTicks(6105), "AQAAAAIAAYagAAAAEBL94qJkJaqM6dzxBZAPhUUFSILRalr5y7oGYe1AvGjqPswYp8f9xRyZTfCujeNzVw==", "6ef04378-5b8f-4abb-8a1f-99354fff7a51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89efebb7-143c-4f7e-bc13-dabc8d86fb9f", new DateTime(2024, 10, 7, 17, 56, 1, 40, DateTimeKind.Local).AddTicks(1124), "AQAAAAIAAYagAAAAEBnIrpY1OLK+JsX6+b1ebGymH7qnuQD2wRaDg/LVCyTOYN52TV6Hu9ExcgoRAH0E5w==", "18c0c09d-2de4-4de0-ae9b-138bf28b8b73" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "863ee9bd-8e89-403c-a063-6a335693f788", "1" },
                    { "0ec12e3a-867f-4f29-aad9-ec942c18ab5f", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "863ee9bd-8e89-403c-a063-6a335693f788", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ec12e3a-867f-4f29-aad9-ec942c18ab5f", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ec12e3a-867f-4f29-aad9-ec942c18ab5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "863ee9bd-8e89-403c-a063-6a335693f788");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "WebPosts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d413c1e7-864a-41d0-b060-a143cc132c98", null, "admin", "admin" },
                    { "d64b49d1-bb3c-413f-b224-784cdb87dee9", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "214cd129-8d5e-44ba-8032-29d4e1d69716", new DateTime(2024, 8, 5, 21, 4, 15, 954, DateTimeKind.Local).AddTicks(4778), "AQAAAAIAAYagAAAAEFOWFcd7Y3IAuLsNTaPpFa3pwV7lGWWkHOO/Hl25JdyUkPvlSICQOf4wd5M75v/hLQ==", "d0eac476-c0c9-4b2d-8330-9b14c025e1fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36e159a0-acce-44ed-8924-a0225262be8b", new DateTime(2024, 8, 5, 21, 4, 16, 25, DateTimeKind.Local).AddTicks(910), "AQAAAAIAAYagAAAAEHgEkqnqFzii5LJW6Lvuf+f9/iIbjraPsA6LBxnh11zAJtByo6VwIgiYeTuIXtXpuA==", "b80c7b9e-3e78-4b81-8b45-e57d63a1007d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d413c1e7-864a-41d0-b060-a143cc132c98", "1" },
                    { "d64b49d1-bb3c-413f-b224-784cdb87dee9", "2" }
                });
        }
    }
}
