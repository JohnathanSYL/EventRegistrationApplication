using EventRegistrationApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventRegistrationApplication.Configurations.Entities
{
    public class EventSeed : IEntityTypeConfiguration<EventModel>
    {
        public void Configure(EntityTypeBuilder<EventModel> builder)
        {
            builder.HasData(
                new EventModel
                {
                    EventId = 1,
                    EventName = "Tech Conference 2025",
                    Date = DateTime.Now.AddMonths(2),
                    Location = "New York",
                    Description = "A conference on the latest technology trends.",
                    VenueId = 1,
                    CategoryId = 1,
                    StatusId = 1,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

