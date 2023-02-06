using Microsoft.EntityFrameworkCore;

namespace _6BSolution.Models
{

    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; }
    }
}
