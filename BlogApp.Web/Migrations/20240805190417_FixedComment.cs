using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class FixedComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e58e0b7-8fda-4a2b-bbfc-093772c58777", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4e6ec5d-3e6b-41e9-9108-49a54e4214b9", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e58e0b7-8fda-4a2b-bbfc-093772c58777");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4e6ec5d-3e6b-41e9-9108-49a54e4214b9");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e58e0b7-8fda-4a2b-bbfc-093772c58777", null, "admin", "admin" },
                    { "e4e6ec5d-3e6b-41e9-9108-49a54e4214b9", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecfa2532-0e9f-4419-a966-223c84b90369", new DateTime(2024, 7, 30, 1, 58, 8, 981, DateTimeKind.Local).AddTicks(8556), "AQAAAAIAAYagAAAAECisF4l9V/W43bx6/l07k4WiMxk2/AIrI/AwpO3hsb5HEBAABTnfotHqh3XZv93MzQ==", "fa447495-40c2-4ffd-a98d-8252f18f3de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9accaef-66cd-458c-b493-c1ed2096a5d8", new DateTime(2024, 7, 30, 1, 58, 9, 52, DateTimeKind.Local).AddTicks(8258), "AQAAAAIAAYagAAAAEDa2MUAN4bHd73cyXwFBjDLRaoY/IpVK1bbstXmiX+IBec/c23QWguuYbwoJ4TR3xw==", "31318e8c-769b-48b4-9931-37e91062225a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6e58e0b7-8fda-4a2b-bbfc-093772c58777", "1" },
                    { "e4e6ec5d-3e6b-41e9-9108-49a54e4214b9", "2" }
                });
        }
    }
}
