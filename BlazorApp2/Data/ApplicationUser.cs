using Microsoft.AspNetCore.Identity;

namespace BlazorApp2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FavouriteColor { get; set; }
        public DateTime BirthDate { get; set; }

    }

}
