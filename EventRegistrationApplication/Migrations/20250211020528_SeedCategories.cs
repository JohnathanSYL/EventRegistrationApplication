using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32f2ee99-a0be-43ba-b57f-9bace58ce3a4", new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(6310), new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(6349), "AQAAAAIAAYagAAAAEJnhvLljampDVmaaAA0xbba5Av7ZIUKcC+FmUC83+fzXXEM7GZUUBiycWFFYQmQxvA==", "529153cf-8ac5-47b4-8e93-bbd8abc698ce" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9179), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9214), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9220), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9237), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9243), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9248), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9253), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9258), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9262), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9267), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 5, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9880), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 6, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9911), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9915), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 7, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9920), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9923), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 8, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9928), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9932), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 9, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9937), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9945), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9948), new DateTime(2025, 2, 11, 10, 5, 27, 74, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 75, DateTimeKind.Local).AddTicks(186), new DateTime(2025, 2, 11, 10, 5, 27, 75, DateTimeKind.Local).AddTicks(187), new DateTime(2025, 2, 11, 10, 5, 27, 75, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 75, DateTimeKind.Local).AddTicks(692), new DateTime(2025, 2, 11, 10, 5, 27, 75, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 75, DateTimeKind.Local).AddTicks(698), new DateTime(2025, 2, 11, 10, 5, 27, 75, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(8389), new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(8402), new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(8409), new DateTime(2025, 2, 11, 10, 5, 27, 257, DateTimeKind.Local).AddTicks(8410) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
