using System.ComponentModel.DataAnnotations;

namespace EventRegistrationApplication.Domain
{
    public class EventModel : BaseDomainModel
    {
        [Key]  // Mark EventId as the primary key
        public int EventId { get; set; }

        [Required(ErrorMessage = "Event Name is required")]
        [StringLength(100, ErrorMessage = "Event Name can't be longer than 100 characters")]
        public string? EventName { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(200, ErrorMessage = "Location can't be longer than 200 characters")]
        public string? Location { get; set; }

        [StringLength(500, ErrorMessage = "Description can't be longer than 500 characters")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Venue ID is required")]
        public int VenueId { get; set; }

        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Status ID is required")]
        public int StatusId { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Date Out is required")]
        public DateTime DateOut { get; set; }

        [Required(ErrorMessage = "Date In is required")]
        public DateTime DateIn { get; set; }
    }
}
