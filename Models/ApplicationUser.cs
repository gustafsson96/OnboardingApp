using Microsoft.AspNetCore.Identity;

// Represents an application user. Extends ASP.NET Identity user with additional fields.
namespace OnboardingApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime? Startdate { get; set; }
    }
}
