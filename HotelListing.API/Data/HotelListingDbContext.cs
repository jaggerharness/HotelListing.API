using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotellistingDbContext : DbContext
    {
        public HotellistingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}