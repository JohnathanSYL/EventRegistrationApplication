using EventRegistrationApplication.Domain;

namespace EventRegistrationApplication.Domain
{
    public class Registration : BaseDomainModel
    {
        public int RegistrationId { get; set; }

        public int UserId { get; set; }
        public int EventId { get; set; }

        public DateTime RegistrationDate { get; set; }
        public int SeatsReserved { get; set; }

        public User? User { get; set; }
        public EventModel? Event { get; set; }
    }
}