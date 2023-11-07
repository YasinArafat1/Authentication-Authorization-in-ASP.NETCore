using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAuthorization.Models.Database
{
    public class DatabaseContext:IdentityDbContext<ApplicationUser> // -- Inherit
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
    }
}
