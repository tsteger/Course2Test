using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Course2Test.Models;

namespace Course2Test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Course2Test.Models.Course> Course { get; set; }
        public DbSet<Course2Test.Models.Module> Module { get; set; }
        public DbSet<Course2Test.Models.Activity> Activity { get; set; }
    }
}
