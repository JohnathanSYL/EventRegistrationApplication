using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddRegistrationUserForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94053c4c-b6d0-4d57-8c2c-826cdc1c6d36", new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(6279), new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(6309), "AQAAAAIAAYagAAAAECHYplZPZEwKYklC1WsdAgNnqFFw64/vZGU3xbp9swTpyDMlL9lRn8gq921960aiAw==", "dd917144-595e-4d57-bda6-3bf9afda6758" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8055), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8082), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8089), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8094), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8099), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8104), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8109), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8114), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8119), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8124), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 5, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8676), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8691), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 6, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8697), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8701), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 7, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8707), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8709), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 8, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8715), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8718), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 9, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8723), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8726), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8731), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8734), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8928), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8929), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(9394), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(9400), new DateTime(2025, 2, 11, 10, 0, 4, 474, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(8294), new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(8307), new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(8313), new DateTime(2025, 2, 11, 10, 0, 4, 636, DateTimeKind.Local).AddTicks(8314) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e895b33d-e016-4f4c-8b3f-4ece6f0c90f7", new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(55), "AQAAAAIAAYagAAAAECZOQ7+WcdvJnp02VcsQh9LsGlR1f1s+XOzwEVdbe9t51IwWVWZYIbPY8ep1WSyt2A==", "c2573409-e528-4249-845b-f2961a582f27" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(803), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(837), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(844), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(860), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(866), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(872), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(878), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(884), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(890), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(895), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 5, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1368), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1400), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 6, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1425), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1430), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 7, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1435), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1439), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 8, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1444), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1448), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 9, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1453), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1457), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1462), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1466), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1688), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(2174), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1306), new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1316), new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1323), new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1324) });
        }
    }
}
