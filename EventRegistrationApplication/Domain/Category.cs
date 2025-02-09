using System.ComponentModel.DataAnnotations;

namespace EventRegistrationApplication.Domain
{
    public class Category : BaseDomainModel
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; } = string.Empty;
    }
}
