using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddProfileImgVariablesToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ProfileBackgroundImgPath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImgPath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "ProfileBackgroundImgPath", "ProfileImgPath", "SecurityStamp" },
                values: new object[] { "37da47d3-9e48-4c56-b573-b4a9595004c8", new DateTime(2024, 10, 13, 14, 35, 31, 183, DateTimeKind.Local).AddTicks(8662), "AQAAAAIAAYagAAAAEA60GFlqGmXdxVDyxXfjRythxwD83NAFOhWFp2EJXlqEFunItvrGSL5mZr+opLCjhA==", null, null, "1f6273d7-1074-4427-ad30-164f2274ed62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "ProfileBackgroundImgPath", "ProfileImgPath", "SecurityStamp" },
                values: new object[] { "8013d6d3-fda0-44ba-a9f5-e4176c57a11b", new DateTime(2024, 10, 13, 14, 35, 31, 254, DateTimeKind.Local).AddTicks(6728), "AQAAAAIAAYagAAAAEGFTlZPsICIfvyY3x5OAB9nQO260tmyEHE493SykLpBMBWTSvnxw60TOSEdgtZYxxQ==", null, null, "da9b432e-b678-4afe-8728-caec1e59c7cb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6449a1bd-f9d1-4e7e-915a-3ce8da57c676", "1" },
                    { "72a18272-d842-40ef-afcd-e8f5c652b079", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ProfileBackgroundImgPath",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileImgPath",
                table: "AspNetUsers");

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
    }
}
