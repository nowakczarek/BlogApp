using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class SetupFriendships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FriendId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FriendStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friendships_AspNetUsers_FriendId",
                        column: x => x.FriendId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friendships_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0739cbe7-404f-4d8a-b5c1-9cce0c29a216", null, "client", "client" },
                    { "0b6dfcd0-819f-4443-963c-3cef0859a1bf", null, "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24a18cd5-3194-41f2-84c1-b4e75fd30e94", new DateTime(2024, 10, 24, 16, 8, 29, 887, DateTimeKind.Local).AddTicks(6300), "AQAAAAIAAYagAAAAEOVhou+RXEf6VmuXwk8oCHn7KGl9oe2QAZ29ZK7YsMW+F5cnC1BoR8mxV3Ygw5JYZg==", "3307ede1-ca5a-4aa9-b814-8dca04d8c9e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15086496-97b1-4872-b391-5e2576156624", new DateTime(2024, 10, 24, 16, 8, 29, 956, DateTimeKind.Local).AddTicks(9884), "AQAAAAIAAYagAAAAELroIy9HBre5BpflMnZEdJ2Mgxtb5Le/KNn6b7MrOc/c7qrpyu1Sd3h1fglFaLp8Rg==", "32814b17-df8d-4b45-b9ea-69e6b0b13a0c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0b6dfcd0-819f-4443-963c-3cef0859a1bf", "1" },
                    { "0739cbe7-404f-4d8a-b5c1-9cce0c29a216", "2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_FriendId",
                table: "Friendships",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_UserId",
                table: "Friendships",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b6dfcd0-819f-4443-963c-3cef0859a1bf", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0739cbe7-404f-4d8a-b5c1-9cce0c29a216", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0739cbe7-404f-4d8a-b5c1-9cce0c29a216");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b6dfcd0-819f-4443-963c-3cef0859a1bf");

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
    }
}
