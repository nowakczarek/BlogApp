using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddWebPostChangesHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "629b03c6-414b-45be-a30e-fdacb5510cf1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d59fa1fb-d658-413d-b81e-5ae9c73fea47", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "629b03c6-414b-45be-a30e-fdacb5510cf1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d59fa1fb-d658-413d-b81e-5ae9c73fea47");

            migrationBuilder.CreateTable(
                name: "WebPostChangesHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contents = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DateTimeOfPost = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WebPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebPostChangesHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebPostChangesHistory_WebPosts_WebPostId",
                        column: x => x.WebPostId,
                        principalTable: "WebPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8180729c-f2b1-41a8-bfd0-e8b61aad3e43", null, "admin", "admin" },
                    { "976f0147-9107-47d3-8dd1-e591a9253ee8", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "793f2c94-e887-46c8-8686-6f70242405b1", new DateTime(2024, 7, 28, 20, 21, 26, 984, DateTimeKind.Local).AddTicks(2590), "AQAAAAIAAYagAAAAEDnVJtT4sqSgiYyv4J4monvPGC47h23setR331tigUEIDou+HvBzyitmuh5MpweLxw==", "98a767a8-5bca-49c6-811e-17bc7cb76f1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ad9be6-4f88-40ca-a119-556aa5c1744e", new DateTime(2024, 7, 28, 20, 21, 27, 54, DateTimeKind.Local).AddTicks(7987), "AQAAAAIAAYagAAAAEM1knBc2iAV6oxCGbZbbI54GCyfdF/FPuuGyTmbNWyQqMhFTZxbWOUGoEMkp9mfqbA==", "0b3e5613-4e06-4e8c-ba34-08d2daf1b85e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8180729c-f2b1-41a8-bfd0-e8b61aad3e43", "1" },
                    { "976f0147-9107-47d3-8dd1-e591a9253ee8", "2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WebPostChangesHistory_WebPostId",
                table: "WebPostChangesHistory",
                column: "WebPostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebPostChangesHistory");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8180729c-f2b1-41a8-bfd0-e8b61aad3e43", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "976f0147-9107-47d3-8dd1-e591a9253ee8", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8180729c-f2b1-41a8-bfd0-e8b61aad3e43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "976f0147-9107-47d3-8dd1-e591a9253ee8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "629b03c6-414b-45be-a30e-fdacb5510cf1", null, "admin", "admin" },
                    { "d59fa1fb-d658-413d-b81e-5ae9c73fea47", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9da3636-ea1a-455c-bbf9-561eb4f65917", new DateTime(2024, 7, 28, 19, 28, 54, 364, DateTimeKind.Local).AddTicks(3286), "AQAAAAIAAYagAAAAEGcgqukCduKUaYlqFm+o1Vw6Mj/di0D6GtylXzrjtZV/g08YxVIPTE4Yhi53PEIkXw==", "a6735253-cb81-40fc-bcac-c73ea3fc1fd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd5ae370-9832-4b85-849f-ceb8fed230e0", new DateTime(2024, 7, 28, 19, 28, 54, 434, DateTimeKind.Local).AddTicks(8164), "AQAAAAIAAYagAAAAEPeuGb/CR4QtwwZU4uaGGwaslwvyMIY+2epCSfW2uJyjFkbcLnMy+zXVTQ9oRfLC7w==", "80ae2dfc-9ddd-45c1-a389-61473534cd06" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "629b03c6-414b-45be-a30e-fdacb5510cf1", "1" },
                    { "d59fa1fb-d658-413d-b81e-5ae9c73fea47", "2" }
                });
        }
    }
}
