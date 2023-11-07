using Microsoft.AspNetCore.Identity;

namespace AuthenticationAuthorization.Models.Database
{
    public class ApplicationUser:IdentityUser //-- Inherit IdentityUser
    {
        public string Name { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
