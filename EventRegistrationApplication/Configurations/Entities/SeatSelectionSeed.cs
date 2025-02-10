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
                    SeatPrice = 100
                },
                new SeatSelection
                {
                    SeatId = 2,
                    SeatPrice = 150
                },
                new SeatSelection
                {
                    SeatId = 3,
                    SeatPrice = 200
                },
                new SeatSelection
                {
                    SeatId = 4,
                    SeatPrice = 250
                }
            );
        }
    }
}
