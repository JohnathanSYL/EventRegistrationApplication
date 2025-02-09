using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventRegistrationApplication.Domain
{
    public class User : BaseDomainModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string? Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string? Email { get; set; } = string.Empty;

        [Required]
        public string? Password { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        [Required]
        public string? Role { get; set; } = string.Empty;

        public string? ProfilePicPreferences { get; set; }
    }
}
