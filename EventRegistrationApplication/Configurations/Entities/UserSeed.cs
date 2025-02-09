using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EventRegistrationApplication.Domain;
using EventRegistrationApplication.Data;

namespace EventRegistrationApplication.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<EventRegistrationApplicationUser>
    {
        public void Configure(EntityTypeBuilder<EventRegistrationApplicationUser> builder)
        {
            var hasher = new PasswordHasher<EventRegistrationApplicationUser>();

            builder.HasData(
                new EventRegistrationApplicationUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",  // Set your GUID here
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,  // Email is confirmed
                    FirstName = "Admin",  // Add FirstName property
                    LastName = "User",  // Add LastName property
                    PhoneNumber = "123-456-7890",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
