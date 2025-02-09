using EventRegistrationApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Composition;

namespace EventRegistrationApplication.Configurations.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Sports & Fitness",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Music & Concert",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Movies",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Arts & Culture",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Conferences & Seminars",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Education & Workshops",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Festivals & Celebrations",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Trade Shows & Expos",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Science & Innovation",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Category
                {
                    CategoryId = 10,
                    CategoryName = "Gaming & Esports",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
