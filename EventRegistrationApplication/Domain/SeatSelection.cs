using System.ComponentModel.DataAnnotations;

namespace EventRegistrationApplication.Domain
{
    public class SeatSelection : BaseDomainModel
    {
        [Key]
        public int SeatId { get; set; }

        [Required(ErrorMessage = "Grid coordinates are required")]
        [StringLength(5, ErrorMessage = "Grid coordinates should be in format A1, B3, etc.")]
        public string? GridCoordinates { get; set; }  // A1, B3, E6, etc.

        [Required(ErrorMessage = "Event ID is required")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Seat Status ID is required")]
        public int SeatStatusId { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }

        public int SeatPrice { get; set; }  // Price for the seat

        // Navigation properties
        public EventModel Event { get; set; }
        public SeatStatusModel SeatStatus { get; set; }
    }
}
