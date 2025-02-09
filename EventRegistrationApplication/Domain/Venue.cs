using System.ComponentModel.DataAnnotations;

namespace EventRegistrationApplication.Domain
{
    public class Venue : BaseDomainModel
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        public string? VenueName { get; set; } = string.Empty;

        [Required]
        public string? Location { get; set; } = string.Empty;

        [Required]
        public int Capacity { get; set; }
    }
}
