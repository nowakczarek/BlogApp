using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_ApplicationUserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_WebPosts_WebPostId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26334e78-b140-40a8-a1f8-7378e114333a", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b51ad18c-b2a8-47ea-b7dc-455925eb1a1f", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26334e78-b140-40a8-a1f8-7378e114333a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b51ad18c-b2a8-47ea-b7dc-455925eb1a1f");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_WebPostId",
                table: "Comments",
                newName: "IX_Comments_WebPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ApplicationUserId",
                table: "Comments",
                newName: "IX_Comments_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_WebPosts_WebPostId",
                table: "Comments",
                column: "WebPostId",
                principalTable: "WebPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_WebPosts_WebPostId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

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

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_WebPostId",
                table: "Comment",
                newName: "IX_Comment_WebPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comment",
                newName: "IX_Comment_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26334e78-b140-40a8-a1f8-7378e114333a", null, "admin", "admin" },
                    { "b51ad18c-b2a8-47ea-b7dc-455925eb1a1f", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "657111fc-d396-4a35-80af-207cb4eeb02e", new DateTime(2024, 7, 30, 1, 50, 36, 964, DateTimeKind.Local).AddTicks(310), "AQAAAAIAAYagAAAAEAS+Wu1aQZrRAcbrWT9JJZzcQBgJoFNleUgzQLpVSGgWGlJZXnTTTHL0zzStezH4KA==", "773ba4cd-a733-484a-a362-d96ab49326db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc420357-0ef0-464f-bed0-a76c35ddf9f4", new DateTime(2024, 7, 30, 1, 50, 37, 34, DateTimeKind.Local).AddTicks(6490), "AQAAAAIAAYagAAAAEAglgWypVoPJ2WHsZkodlhs3ugUroIH9hjokmWPynv6pdQZFKOFkfOHJuMYJ0oPeeA==", "22d666b6-b8bc-47fb-be06-062a5032437a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "26334e78-b140-40a8-a1f8-7378e114333a", "1" },
                    { "b51ad18c-b2a8-47ea-b7dc-455925eb1a1f", "2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_ApplicationUserId",
                table: "Comment",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_WebPosts_WebPostId",
                table: "Comment",
                column: "WebPostId",
                principalTable: "WebPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
