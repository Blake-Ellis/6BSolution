using System.ComponentModel.DataAnnotations;

namespace _6BSolution.ViewModels
{
    public class BookingViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }
        [Required]
        public string Flexibility { get; set; }
        [Required]
        [Display(Name = "Vehicle Size")]
        public string VehicleSize { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        [Phone]
        public string ContactNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
