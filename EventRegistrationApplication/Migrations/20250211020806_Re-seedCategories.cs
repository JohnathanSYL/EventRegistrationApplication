using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class ReseedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56cb8d20-c5db-4df1-8877-a4d604ca9bce", new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(1194), new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(1227), "AQAAAAIAAYagAAAAECrSRmNjsIYaxBIciPD4IC6wSDLItM3i5N5KMfMBylADtitYYCY37y4N9V4AY76BfQ==", "eba09a68-f8ca-4175-86e8-ec603428fab5" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4083), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4112), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4117), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4135), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4140), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4145), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4150), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4155), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4159), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4164), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 5, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4658), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 6, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4683), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4687), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 7, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4692), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4694), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 8, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4699), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4702), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 9, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4708), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4711), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4716), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4719), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4915), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4916), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(5367), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(5373), new DateTime(2025, 2, 11, 10, 8, 4, 857, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(2788), new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(2800), new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(2807), new DateTime(2025, 2, 11, 10, 8, 5, 15, DateTimeKind.Local).AddTicks(2808) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
