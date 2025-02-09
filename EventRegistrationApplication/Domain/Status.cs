using System.ComponentModel.DataAnnotations;

namespace EventRegistrationApplication.Domain
{
    public class Status : BaseDomainModel
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        public string? StatusName { get; set; } = string.Empty;
    }
}
