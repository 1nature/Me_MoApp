using Me_MoApp;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<UserData> UserData { get; set; } 
        //public DbSet<Page> Pages { get; set; }
        public DbSet<Vendor> VendorData { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
