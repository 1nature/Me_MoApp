using Microsoft.AspNetCore.Identity;
using Me_MoApp;

namespace BlazorApp2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public UserData? UserData { get; set; } 

    }

}





