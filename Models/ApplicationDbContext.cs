using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CONTACTS.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Allcontacts> Allcontacts { get; set; }
        public DbSet<Gender> Genders { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}