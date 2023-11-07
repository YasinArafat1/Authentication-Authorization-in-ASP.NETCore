using System.ComponentModel.DataAnnotations;

namespace AuthenticationAuthorization.Models.DTO
{
    public class RgistrationModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string ? Role { get; set; }
    }
}
