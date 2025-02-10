using EventRegistrationApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventRegistrationApplication.Configurations.Entities
{
    public class SeatStatusSeed : IEntityTypeConfiguration<SeatStatusModel>
    {
        public void Configure(EntityTypeBuilder<SeatStatusModel> builder)
        {
            builder.HasData(
                new SeatStatusModel
                {
                    SeatStatusId = 1,
                    StatusName = "Available"
                },
                new SeatStatusModel
                {
                    SeatStatusId = 2,
                    StatusName = "Reserved"
                },
                new SeatStatusModel
                {
                    SeatStatusId = 3,
                    StatusName = "Occupied"
                }
            );
        }
    }
}

