using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XJTResourcesCore.Models;

using OpenIddict;
using OpenIddict.Models;

namespace XJTResourcesCore.Data
{
    public class ApplicationDbContext : OpenIddictContext<ApplicationUser, Application, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        

        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<AspNetUserEx> AspNetUserExts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Correction> Corrections { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<Email> Contacts { get; set; }

        public DbSet<Faq> FAQs { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Jumpseat> Jumpseats { get; set; }

        public DbSet<Link> Links { get; set; }

        public DbSet<Models.Version> Versions { get; set; }
    }
}
