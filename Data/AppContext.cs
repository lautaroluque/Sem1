using Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Data
{
    public class AppContext : IdentityDbContext<ApplicationUser>
    {
        public AppContext() : base("Sem1Db", throwIfV1Schema: false)
        {
        }

        public static AppContext Create()
        {
            return new AppContext();
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
