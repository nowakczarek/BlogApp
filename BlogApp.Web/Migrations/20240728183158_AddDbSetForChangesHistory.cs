using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddDbSetForChangesHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebPostChangesHistory_WebPosts_WebPostId",
                table: "WebPostChangesHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebPostChangesHistory",
                table: "WebPostChangesHistory");

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

            migrationBuilder.RenameTable(
                name: "WebPostChangesHistory",
                newName: "WebPostsChangesHistory");

            migrationBuilder.RenameIndex(
                name: "IX_WebPostChangesHistory_WebPostId",
                table: "WebPostsChangesHistory",
                newName: "IX_WebPostsChangesHistory_WebPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebPostsChangesHistory",
                table: "WebPostsChangesHistory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "99184e64-71f8-48ea-95b4-573487cf35ae", null, "client", "client" },
                    { "b5a94913-917b-427f-8b1a-47719880dad2", null, "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26b64027-5acc-42b3-8316-d30a4aec023a", new DateTime(2024, 7, 28, 20, 31, 56, 976, DateTimeKind.Local).AddTicks(2983), "AQAAAAIAAYagAAAAEAdjT0RXvYlNe1F6ATpUhELUemHGG4feID34PiKMEuRMk1StEkDPfP9iK29oJWuVlg==", "beb5cc53-4aea-4c8a-b39e-95e0e9231db8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df8377df-65b2-451d-a366-c595ff061ff3", new DateTime(2024, 7, 28, 20, 31, 57, 46, DateTimeKind.Local).AddTicks(6555), "AQAAAAIAAYagAAAAECYV199S7Mw7aI81Mgzle5cMH2RW+CubJQxJd8E6Ip2JwYGvRb5dvOb1X3aGpMqS3A==", "ac65d331-7779-44f5-9a77-46aeb6c75849" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b5a94913-917b-427f-8b1a-47719880dad2", "1" },
                    { "99184e64-71f8-48ea-95b4-573487cf35ae", "2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WebPostsChangesHistory_WebPosts_WebPostId",
                table: "WebPostsChangesHistory",
                column: "WebPostId",
                principalTable: "WebPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebPostsChangesHistory_WebPosts_WebPostId",
                table: "WebPostsChangesHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebPostsChangesHistory",
                table: "WebPostsChangesHistory");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b5a94913-917b-427f-8b1a-47719880dad2", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "99184e64-71f8-48ea-95b4-573487cf35ae", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99184e64-71f8-48ea-95b4-573487cf35ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5a94913-917b-427f-8b1a-47719880dad2");

            migrationBuilder.RenameTable(
                name: "WebPostsChangesHistory",
                newName: "WebPostChangesHistory");

            migrationBuilder.RenameIndex(
                name: "IX_WebPostsChangesHistory_WebPostId",
                table: "WebPostChangesHistory",
                newName: "IX_WebPostChangesHistory_WebPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebPostChangesHistory",
                table: "WebPostChangesHistory",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_WebPostChangesHistory_WebPosts_WebPostId",
                table: "WebPostChangesHistory",
                column: "WebPostId",
                principalTable: "WebPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
