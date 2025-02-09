using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "DateCreated", "DateUpdated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "04a91b13-615a-44a1-bce7-661f381f682b", "System", new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(4949), new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(4981), "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHXOsam5mZ4H2H9ouY1pmOj8K+L7twpsdOF8XJtv2maTMtvpaEYuPBvV2PXHJNv20w==", "123-456-7890", false, "6c63baa9-e3fd-4c75-923c-43b5c8b1dadf", false, "System", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1157), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1195), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 4, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1710), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1754), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1965), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1966), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(2523), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(2530), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(6235), new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(8501), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(8535), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 4, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9026), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9067), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9250), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9251), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9416), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9422), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "Password", "PhoneNumber", "ProfilePicPreferences", "Role", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9592), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9593), "admin@example.com", "Admin User", "password123", "123-456-7890", null, "Admin", "System" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9770), new DateTime(2025, 2, 9, 14, 37, 56, 654, DateTimeKind.Local).AddTicks(9772) });
        }
    }
}
