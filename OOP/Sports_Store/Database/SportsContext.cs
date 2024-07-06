using Microsoft.EntityFrameworkCore;
using Sports_store.Models;

namespace Sports_store.Database
{
    public class SportsContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Good> Goods { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<BasketGood> BasketGoods { get; set; }

        public DbSet<Order> Orders { get; set; }
        public SportsContext() : base()
        {
            Database.EnsureCreated();
            AddAdmin();
        }

        private void AddAdmin()
        {
            if (!(Users.Where(u => u.IsAdmin == 1).Any()))
            {
                Users.Add(new User
                {
                    Login = "admin",
                    Password = "qweqweqwe",
                    Name = "admin",
                    Surname = "admin",
                    Description = "admin",
                    PhoneNumber = "+375000000000",
                    Email = "admin@gmail.com",
                    IsAdmin = 1,
                    Image = null,
                });
                SaveChanges();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=Sports_Store;Integrated Security=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasKey(e => e.Id);
            builder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Login).IsUnique();
            });
            builder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            builder.Entity<BasketGood>()
    .HasOne(bg => bg.Good)
    .WithMany(g => g.BasketGoods)
    .HasForeignKey(bg => bg.GoodId);

            builder.Entity<BasketGood>()
    .HasOne(bg => bg.User)
    .WithMany(u => u.BasketGoods)
    .HasForeignKey(bg => bg.UserId);

            builder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);
            builder.Entity<Order>()
    .HasOne(r => r.User)
    .WithMany(u => u.Orders)
    .HasForeignKey(r => r.UserId);

            builder.Entity<Review>()
    .HasOne(r => r.Good)
    .WithMany(u => u.Reviews)
    .HasForeignKey(r => r.GoodId);
        }
    }
}
