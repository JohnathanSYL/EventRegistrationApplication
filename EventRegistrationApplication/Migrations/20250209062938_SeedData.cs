using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Technology", "System", new DateTime(2025, 2, 9, 14, 29, 36, 996, DateTimeKind.Local).AddTicks(9421), new DateTime(2025, 2, 9, 14, 29, 36, 996, DateTimeKind.Local).AddTicks(9446), "System" },
                    { 2, "AI", "System", new DateTime(2025, 2, 9, 14, 29, 36, 996, DateTimeKind.Local).AddTicks(9454), new DateTime(2025, 2, 9, 14, 29, 36, 996, DateTimeKind.Local).AddTicks(9455), "System" }
                });

            migrationBuilder.InsertData(
                table: "EventModel",
                columns: new[] { "EventId", "CategoryId", "CreatedBy", "Date", "DateCreated", "DateIn", "DateOut", "DateUpdated", "Description", "EventName", "Location", "StatusId", "UpdatedBy", "UserId", "VenueId" },
                values: new object[] { 1, 1, "System", new DateTime(2025, 4, 9, 14, 29, 36, 996, DateTimeKind.Local).AddTicks(9846), new DateTime(2025, 2, 9, 14, 29, 36, 996, DateTimeKind.Local).AddTicks(9884), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 14, 29, 36, 996, DateTimeKind.Local).AddTicks(9885), "A conference on the latest technology trends.", "Tech Conference 2025", "New York", 1, "System", 1, 1 });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "CreatedBy", "DateCreated", "DateUpdated", "StatusName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(217), new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(218), "Active", "System" },
                    { 2, "System", new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(223), new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(224), "Inactive", "System" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "Password", "PhoneNumber", "ProfilePicPreferences", "Role", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(386), new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(388), "admin@example.com", "Admin User", "password123", "123-456-7890", null, "Admin", "System" });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Location", "UpdatedBy", "VenueName" },
                values: new object[] { 1, 500, "System", new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(570), new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(571), "Los Angeles", "System", "Convention Center" });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "RegistrationId", "CreatedBy", "DateCreated", "DateUpdated", "EventId", "RegistrationDate", "SeatsReserved", "UpdatedBy", "UserId" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(55), new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(56), 1, new DateTime(2025, 2, 9, 14, 29, 36, 997, DateTimeKind.Local).AddTicks(53), 2, "System", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
