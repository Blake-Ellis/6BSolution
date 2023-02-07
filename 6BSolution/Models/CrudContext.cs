using Microsoft.EntityFrameworkCore;
using bc = BCrypt.Net.BCrypt;

namespace _6BSolution.Models
{

    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var hashedPassword = bc.HashPassword("Password123");

            modelBuilder.Entity<User>().HasData(new User { UserID = 1, Email = "TechnicalTest@gmail.com", Password = hashedPassword });
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
