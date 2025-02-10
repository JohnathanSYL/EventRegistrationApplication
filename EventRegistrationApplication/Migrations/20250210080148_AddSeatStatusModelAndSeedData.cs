using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddSeatStatusModelAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeatStatuses",
                columns: table => new
                {
                    SeatStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatStatuses", x => x.SeatStatusId);
                });

            migrationBuilder.CreateTable(
                name: "seatSelections",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GridCoordinates = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    SeatStatusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeatPrice = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seatSelections", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_seatSelections_EventModel_EventId",
                        column: x => x.EventId,
                        principalTable: "EventModel",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_seatSelections_SeatStatuses_SeatStatusId",
                        column: x => x.SeatStatusId,
                        principalTable: "SeatStatuses",
                        principalColumn: "SeatStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7d7a4c0-31dd-48dc-be92-08ccd38abf43", new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(8221), new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(8240), "AQAAAAIAAYagAAAAEMFa9GSIBS9M7I32sbdkTeEfhzVZlH2+kiA3DNYP0tCTzVFdbIU+v0WOpoAXNYup4Q==", "c8900b59-6274-467e-b6b2-0809c371fb27" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9078), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9123), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9125), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9128), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9130), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9132), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9134), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9137), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9139), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 5, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9552), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9587), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 6, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9591), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9593), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 7, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9595), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9596), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 8, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9599), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9600), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 9, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9602), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9603), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9606), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9607), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "RegistrationId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9791), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9792), new DateTime(2025, 2, 10, 16, 1, 47, 58, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.InsertData(
                table: "SeatStatuses",
                columns: new[] { "SeatStatusId", "StatusName" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Reserved" },
                    { 3, "Occupied" }
                });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 59, DateTimeKind.Local).AddTicks(272), new DateTime(2025, 2, 10, 16, 1, 47, 59, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 59, DateTimeKind.Local).AddTicks(276), new DateTime(2025, 2, 10, 16, 1, 47, 59, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(9204), new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(9210), new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(9213), new DateTime(2025, 2, 10, 16, 1, 47, 119, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.InsertData(
                table: "seatSelections",
                columns: new[] { "SeatId", "CreatedBy", "DateCreated", "DateUpdated", "EventId", "GridCoordinates", "SeatPrice", "SeatStatusId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9691), new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9691), 1, "A1", 100, 1, "", 0 },
                    { 2, "", new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9696), new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9697), 1, "A2", 150, 2, "", 0 },
                    { 3, "", new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9698), new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9699), 1, "B1", 200, 1, "", 0 },
                    { 4, "", new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9700), new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9700), 1, "B2", 250, 1, "", 0 },
                    { 5, "", new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9702), new DateTime(2025, 2, 10, 8, 1, 47, 119, DateTimeKind.Utc).AddTicks(9702), 2, "C1", 120, 3, "", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_seatSelections_EventId",
                table: "seatSelections",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_seatSelections_SeatStatusId",
                table: "seatSelections",
                column: "SeatStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "seatSelections");

            migrationBuilder.DropTable(
                name: "SeatStatuses");

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
