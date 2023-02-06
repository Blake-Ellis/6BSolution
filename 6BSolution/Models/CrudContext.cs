using Microsoft.EntityFrameworkCore;

namespace _6BSolution.Models
{
    public class CrudContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
    }
}
