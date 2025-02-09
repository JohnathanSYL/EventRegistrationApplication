using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EventRegistrationApplication.Data;
using EventRegistrationApplication.Configurations.Entities;
using EventRegistrationApplication.Domain;

namespace EventRegistrationApplication.Data
{
    public class EventRegistrationApplicationContext(DbContextOptions<EventRegistrationApplicationContext> options) : IdentityDbContext<EventRegistrationApplicationUser>(options)
    {
        public DbSet<EventRegistrationApplication.Domain.Category> Category { get; set; } = default!;
        public DbSet<EventRegistrationApplication.Domain.EventModel> EventModel { get; set; } = default!;
        public DbSet<EventRegistrationApplication.Domain.Registration> Registration { get; set; } = default!;
        public DbSet<EventRegistrationApplication.Domain.Status> Status { get; set; } = default!;
        public DbSet<EventRegistrationApplication.Domain.User> User { get; set; } = default!;
        public DbSet<EventRegistrationApplication.Domain.Venue> Venue { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new EventSeed());
            builder.ApplyConfiguration(new RegistrationSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new StatusSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new VenueSeed());
        }
    }
}
