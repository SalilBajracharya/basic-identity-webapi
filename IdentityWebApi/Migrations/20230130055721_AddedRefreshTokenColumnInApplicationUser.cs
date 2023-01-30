using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedRefreshTokenColumnInApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff8cf3dc-3fab-46e8-86d8-12348f8b5409");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8f82deb-38cd-44ee-8099-e072aa345d11", "7b825015-26a8-4ad0-b935-f7792833d36c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8f82deb-38cd-44ee-8099-e072aa345d11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b825015-26a8-4ad0-b935-f7792833d36c");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b97dbee-96f6-48d8-bc13-c78127708791", null, "User", "USER" },
                    { "aaef1ec8-36d0-4d74-9505-c078d7162004", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6004372a-b93a-417f-b925-0c1496bd16aa", 0, "b241d12a-cd4b-4f9c-acc5-4073ff16bb36", "d.admin@example.com", false, false, null, "D.ADMIN@EXAMPLE.COM", "D.ADMIN", "AQAAAAIAAYagAAAAEL/dCUSHZmnXnNyLJeI2tvAIa+4KehordKJrbQKVNtvSrQDdba29A2o7LodQIrB2yA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "af3ac4fa-1042-48a9-a6d4-016ca26b664c", false, "d.admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aaef1ec8-36d0-4d74-9505-c078d7162004", "6004372a-b93a-417f-b925-0c1496bd16aa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b97dbee-96f6-48d8-bc13-c78127708791");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aaef1ec8-36d0-4d74-9505-c078d7162004", "6004372a-b93a-417f-b925-0c1496bd16aa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaef1ec8-36d0-4d74-9505-c078d7162004");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6004372a-b93a-417f-b925-0c1496bd16aa");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8f82deb-38cd-44ee-8099-e072aa345d11", null, "Admin", "ADMIN" },
                    { "ff8cf3dc-3fab-46e8-86d8-12348f8b5409", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b825015-26a8-4ad0-b935-f7792833d36c", 0, "4607f042-eedb-4b9b-9db3-3e1ef94102bc", "d.admin@example.com", false, false, null, "D.ADMIN@EXAMPLE.COM", "D.ADMIN", "AQAAAAIAAYagAAAAEBIx6cGXQ6J3bir/2wt4lFzON9DDKSYXKYjL3+2L36MF7DMaeHOXCq5FZ/xYBPKVoA==", null, false, "429665d3-1174-4ff8-b8a0-47f076348d9a", false, "d.admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c8f82deb-38cd-44ee-8099-e072aa345d11", "7b825015-26a8-4ad0-b935-f7792833d36c" });
        }
    }
}
