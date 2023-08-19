using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotellistingDbContext : DbContext
    {
        public HotellistingDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}