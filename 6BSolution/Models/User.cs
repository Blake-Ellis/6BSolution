using System.ComponentModel.DataAnnotations;

namespace _6BSolution.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
