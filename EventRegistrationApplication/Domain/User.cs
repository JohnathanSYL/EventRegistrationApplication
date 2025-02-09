using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventRegistrationApplication.Domain
{
    public class User : BaseDomainModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public string? PhoneNumber { get; set; }

        [Required]
        public string? Role { get; set; }

        public string? ProfilePicPreferences { get; set; }
    }
}
