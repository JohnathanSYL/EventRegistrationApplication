using EventRegistrationApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventRegistrationApplication.Configurations.Entities
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                new Venue
                {
                    VenueId = 1,
                    VenueName = "National Stadium",
                    Location = "Singapore",
                    Capacity = 55000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Venue
                {
                    VenueId = 2,
                    VenueName = "Singapore Indoor Stadium",
                    Location = "Singapore",
                    Capacity = 12000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Venue
                {
                    VenueId = 3,
                    VenueName = "Gateway Theatre (Main Theatre)",
                    Location = "Singapore",
                    Capacity = 922,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
