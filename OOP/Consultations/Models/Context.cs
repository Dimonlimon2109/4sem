using Microsoft.EntityFrameworkCore;

namespace Consultations.Models
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public Context() : base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=Consultations;Integrated Security=True;TrustServerCertificate=true;");
        }

    }
}
