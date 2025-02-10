using EventRegistrationApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventRegistrationApplication.Configurations.Entities
{
    public class SeatSelectionSeed : IEntityTypeConfiguration<SeatSelection>
    {
        public void Configure(EntityTypeBuilder<SeatSelection> builder)
        {
            builder.HasData(
                new SeatSelection
                {
                    SeatId = 1,
                    GridCoordinates = "A1",
                    EventId = 1,  // Assuming EventId 1 exists
                    SeatStatusId = 1,  // "Available"
                    UserId = 0,  // No user reserved this seat
                    SeatPrice = 100
                },
                new SeatSelection
                {
                    SeatId = 2,
                    GridCoordinates = "A2",
                    EventId = 1,
                    SeatStatusId = 2,  // "Reserved"
                    UserId = 0,
                    SeatPrice = 150
                },
                new SeatSelection
                {
                    SeatId = 3,
                    GridCoordinates = "B1",
                    EventId = 1,
                    SeatStatusId = 1,  // "Available"
                    UserId = 0,
                    SeatPrice = 200
                },
                new SeatSelection
                {
                    SeatId = 4,
                    GridCoordinates = "B2",
                    EventId = 1,
                    SeatStatusId = 1,  // "Available"
                    UserId = 0,
                    SeatPrice = 250
                },
                new SeatSelection
                {
                    SeatId = 5,
                    GridCoordinates = "C1",
                    EventId = 2,  // Another event
                    SeatStatusId = 3,  // "Occupied"
                    UserId = 1,  // Reserved by user with ID 1
                    SeatPrice = 120
                }
            );
        }
    }
}
