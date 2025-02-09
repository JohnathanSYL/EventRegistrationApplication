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
                    EventName = "Football Match: Liverpool vs Man City",
                    Date = DateTime.Now.AddMonths(3),
                    Location = "National Stadium",
                    Description = "A thrilling Premier League clash between Liverpool and Man City.",
                    VenueId = 1,
                    CategoryId = 1,
                    StatusId = 1,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new EventModel
                {
                    EventId = 2,
                    EventName = "Music Event: Music Concert by JJ Lin",
                    Date = DateTime.Now.AddMonths(4),
                    Location = "Singapore Indoor Stadium",
                    Description = "A captivating music concert by JJ Lin, featuring his iconic hits.",
                    VenueId = 2,
                    CategoryId = 2,
                    StatusId = 1,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new EventModel
                {
                    EventId = 3,
                    EventName = "Movie Event: Godzilla Vs Groot",
                    Date = DateTime.Now.AddMonths(5),
                    Location = "Gateway Theatre (Main Theatre)",
                    Description = "An epic movie showdown between Godzilla and Groot.",
                    VenueId = 3,
                    CategoryId = 3,
                    StatusId = 1,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new EventModel
                {
                    EventId = 4,
                    EventName = "Movie Event: Hello Kitty joined the fight of the titans! ft Attack on Titans",
                    Date = DateTime.Now.AddMonths(6),
                    Location = "Gateway Theatre (Main Theatre)",
                    Description = "Hello Kitty enters the titan battle, joining forces with the Attack on Titan crew in an unexpected crossover!",
                    VenueId = 3,
                    CategoryId = 3,
                    StatusId = 1,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new EventModel
                {
                    EventId = 5,
                    EventName = "Football Match: Arsenal vs Newcastle",
                    Date = DateTime.Now.AddMonths(7),
                    Location = "National Stadium",
                    Description = "Arsenal will take on Newcastle in a high-stakes Carabao Cup clash at the Emirates, aiming to bounce back from a tough first-leg result.",
                    VenueId = 1,
                    CategoryId = 1,
                    StatusId = 1,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new EventModel
                {
                    EventId = 6,
                    EventName = "Music Event: Music Concert by G.E.M",
                    Date = DateTime.Now.AddMonths(10),
                    Location = "Singapore Indoor Stadium",
                    Description = "Enjoy an unforgettable night of soulful melodies and powerful performances at G.E.M's music concert!",
                    VenueId = 2,
                    CategoryId = 2,
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

