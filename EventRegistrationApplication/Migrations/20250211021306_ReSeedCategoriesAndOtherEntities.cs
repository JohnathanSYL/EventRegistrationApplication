using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class ReSeedCategoriesAndOtherEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e83ea98f-faff-431b-8e85-59e23a25a6a4", new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(8650), new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(8675), "AQAAAAIAAYagAAAAEIsi/crHTsWTGLoyEzHvZQKCYzXJ6IDi5mNfKFNEck+jaXF6ECb3F4ertL7885DNRQ==", "4156acdb-90f0-4428-a01c-232f9319fb54" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3709), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3743), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3749), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3761), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3766), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3770), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3776), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3780), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3785), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3790), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 5, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4419), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4465), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 6, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4495), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4499), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 7, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4504), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4507), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 8, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4542), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4545), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 9, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4550), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4553), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4558), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4561), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4782), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4783), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5331), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5337), new DateTime(2025, 2, 11, 10, 13, 4, 268, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9945), new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9955), new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 2, 11, 10, 13, 4, 437, DateTimeKind.Local).AddTicks(9963) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
