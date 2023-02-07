using System.ComponentModel.DataAnnotations;

namespace _6BSolution.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }
        public string Flexibility { get; set; }
        [Display(Name = "Vehicle Size")]
        public string VehicleSize { get; set; }
        [Display(Name = "Contact Number")]
        [Phone]
        public string ContactNumber { get; set; }
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
