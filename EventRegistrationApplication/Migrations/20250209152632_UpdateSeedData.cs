using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistrationApplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Sports & Fitness", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(803), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Music & Concert", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(837), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "Movies", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(844), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(846), "System" },
                    { 4, "Arts & Culture", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(860), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(862), "System" },
                    { 5, "Conferences & Seminars", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(866), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(867), "System" },
                    { 6, "Education & Workshops", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(872), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(873), "System" },
                    { 7, "Festivals & Celebrations", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(878), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(879), "System" },
                    { 8, "Trade Shows & Expos", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(884), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(885), "System" },
                    { 9, "Science & Innovation", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(890), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(891), "System" },
                    { 10, "Gaming & Esports", "System", new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(895), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(897), "System" }
                });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated", "Description", "EventName", "Location" },
                values: new object[] { new DateTime(2025, 5, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1368), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1400), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1420), "A thrilling Premier League clash between Liverpool and Man City.", "Football Match: Liverpool vs Man City", "National Stadium" });

            migrationBuilder.InsertData(
                table: "EventModel",
                columns: new[] { "EventId", "CategoryId", "CreatedBy", "Date", "DateCreated", "DateIn", "DateOut", "DateUpdated", "Description", "EventName", "Location", "StatusId", "UpdatedBy", "UserId", "VenueId" },
                values: new object[,]
                {
                    { 2, 2, "System", new DateTime(2025, 6, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1425), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1430), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1431), "A captivating music concert by JJ Lin, featuring his iconic hits.", "Music Event: Music Concert by JJ Lin", "Singapore Indoor Stadium", 1, "System", 1, 2 },
                    { 3, 3, "System", new DateTime(2025, 7, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1435), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1440), "An epic movie showdown between Godzilla and Groot.", "Movie Event: Godzilla Vs Groot", "Gateway Theatre (Main Theatre)", 1, "System", 1, 3 },
                    { 4, 3, "System", new DateTime(2025, 8, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1444), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1448), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1449), "Hello Kitty enters the titan battle, joining forces with the Attack on Titan crew in an unexpected crossover!", "Movie Event: Hello Kitty joined the fight of the titans! ft Attack on Titans", "Gateway Theatre (Main Theatre)", 1, "System", 1, 3 },
                    { 5, 1, "System", new DateTime(2025, 9, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1453), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1457), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1458), "Arsenal will take on Newcastle in a high-stakes Carabao Cup clash at the Emirates, aiming to bounce back from a tough first-leg result.", "Football Match: Arsenal vs Newcastle", "National Stadium", 1, "System", 1, 1 },
                    { 6, 2, "System", new DateTime(2025, 12, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1462), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1466), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 23, 26, 30, 428, DateTimeKind.Local).AddTicks(1467), "Enjoy an unforgettable night of soulful melodies and powerful performances at G.E.M's music concert!", "Music Event: Music Concert by G.E.M", "Singapore Indoor Stadium", 1, "System", 1, 2 }
                });

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
                columns: new[] { "Capacity", "DateCreated", "DateUpdated", "Location", "VenueName" },
                values: new object[] { 55000, new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1306), new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1310), "Singapore", "National Stadium" });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Location", "UpdatedBy", "VenueName" },
                values: new object[,]
                {
                    { 2, 12000, "System", new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1316), new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1317), "Singapore", "System", "Singapore Indoor Stadium" },
                    { 3, 922, "System", new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1323), new DateTime(2025, 2, 9, 23, 26, 30, 581, DateTimeKind.Local).AddTicks(1324), "Singapore", "System", "Gateway Theatre (Main Theatre)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04a91b13-615a-44a1-bce7-661f381f682b", new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(4949), new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(4981), "AQAAAAIAAYagAAAAEHXOsam5mZ4H2H9ouY1pmOj8K+L7twpsdOF8XJtv2maTMtvpaEYuPBvV2PXHJNv20w==", "6c63baa9-e3fd-4c75-923c-43b5c8b1dadf" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "Technology", new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1157), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { "AI", new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1195), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "EventModel",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated", "Description", "EventName", "Location" },
                values: new object[] { new DateTime(2025, 4, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1710), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1754), new DateTime(2025, 2, 9, 15, 40, 57, 731, DateTimeKind.Local).AddTicks(1755), "A conference on the latest technology trends.", "Tech Conference 2025", "New York" });

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
                columns: new[] { "Capacity", "DateCreated", "DateUpdated", "Location", "VenueName" },
                values: new object[] { 500, new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(6235), new DateTime(2025, 2, 9, 15, 40, 57, 882, DateTimeKind.Local).AddTicks(6238), "Los Angeles", "Convention Center" });
        }
    }
}
