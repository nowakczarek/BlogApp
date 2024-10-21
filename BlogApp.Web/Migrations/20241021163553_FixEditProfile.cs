using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class FixEditProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6449a1bd-f9d1-4e7e-915a-3ce8da57c676", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72a18272-d842-40ef-afcd-e8f5c652b079", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449a1bd-f9d1-4e7e-915a-3ce8da57c676");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72a18272-d842-40ef-afcd-e8f5c652b079");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87e6f337-4ef3-4954-8a1b-c61e61a21b1a", null, "client", "client" },
                    { "a9e1db06-e785-4bc9-ad24-3df2ddde9d9f", null, "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ddbfe10-1658-489c-a53c-dbcf8a11aeac", new DateTime(2024, 10, 21, 18, 35, 52, 126, DateTimeKind.Local).AddTicks(5912), "AQAAAAIAAYagAAAAEMGSnN5Vgxtc7OmggA4LVG/RuZslawm+RLD1tCbMOxgwkwuwkshIT/Y1HMFsQ0GuQw==", "d9d1639c-6c92-43c2-96a0-c2463189596d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eea22b0c-813e-4b6d-b6ce-97ae7fb2a588", new DateTime(2024, 10, 21, 18, 35, 52, 197, DateTimeKind.Local).AddTicks(9227), "AQAAAAIAAYagAAAAEF1iw1/A1sCjzfzNZ05hu4OLzsMs87B6y/h+tJn2pre3Ztk567Q43ZnPIYCP3tCPDg==", "33f99a2d-61a7-4b5d-86c5-eac126453921" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a9e1db06-e785-4bc9-ad24-3df2ddde9d9f", "1" },
                    { "87e6f337-4ef3-4954-8a1b-c61e61a21b1a", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9e1db06-e785-4bc9-ad24-3df2ddde9d9f", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87e6f337-4ef3-4954-8a1b-c61e61a21b1a", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87e6f337-4ef3-4954-8a1b-c61e61a21b1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9e1db06-e785-4bc9-ad24-3df2ddde9d9f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6449a1bd-f9d1-4e7e-915a-3ce8da57c676", null, "admin", "admin" },
                    { "72a18272-d842-40ef-afcd-e8f5c652b079", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37da47d3-9e48-4c56-b573-b4a9595004c8", new DateTime(2024, 10, 13, 14, 35, 31, 183, DateTimeKind.Local).AddTicks(8662), "AQAAAAIAAYagAAAAEA60GFlqGmXdxVDyxXfjRythxwD83NAFOhWFp2EJXlqEFunItvrGSL5mZr+opLCjhA==", "1f6273d7-1074-4427-ad30-164f2274ed62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8013d6d3-fda0-44ba-a9f5-e4176c57a11b", new DateTime(2024, 10, 13, 14, 35, 31, 254, DateTimeKind.Local).AddTicks(6728), "AQAAAAIAAYagAAAAEGFTlZPsICIfvyY3x5OAB9nQO260tmyEHE493SykLpBMBWTSvnxw60TOSEdgtZYxxQ==", "da9b432e-b678-4afe-8728-caec1e59c7cb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6449a1bd-f9d1-4e7e-915a-3ce8da57c676", "1" },
                    { "72a18272-d842-40ef-afcd-e8f5c652b079", "2" }
                });
        }
    }
}
