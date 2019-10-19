using Microsoft.AspNetCore.Identity;

namespace e_cosmetics.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }   
    }
}
