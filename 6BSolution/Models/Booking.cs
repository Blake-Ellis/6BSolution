using System.ComponentModel.DataAnnotations;

namespace _6BSolution.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string BookingDate { get; set; }
        public string Flexibility { get; set; }
        public string VehicleSize { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
