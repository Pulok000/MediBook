using Microsoft.AspNetCore.Identity;

namespace MediBook.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
