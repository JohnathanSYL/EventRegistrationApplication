using System.ComponentModel.DataAnnotations;
namespace EventRegistrationApplication.Domain
{
    public class SeatSelection : BaseDomainModel
    {
        [Key]
        public int SeatId { get; set; }
        public int SeatPrice { get; set; }
       
    }
}
