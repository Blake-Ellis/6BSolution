using Microsoft.Build.Framework;

namespace _6BSolution.ViewModels
{
    public class LoginFormViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
