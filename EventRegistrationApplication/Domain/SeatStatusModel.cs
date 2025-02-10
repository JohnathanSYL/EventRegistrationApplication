using System.ComponentModel.DataAnnotations;

namespace EventRegistrationApplication.Domain
{
    public class SeatStatusModel
    {
        [Key]
        public int SeatStatusId { get; set; }

        [Required]
        [StringLength(50)]
        public string? StatusName { get; set; }  // e.g., "Available", "Reserved", "Occupied"
    }
}
