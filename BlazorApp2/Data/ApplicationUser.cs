using Microsoft.AspNetCore.Identity;
using Me_MoApp;

namespace BlazorApp2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //public string? FavouriteColor { get; set; }
        //public DateTime BirthDate { get; set; }
        public User? User { get; set; } 

    }

}





