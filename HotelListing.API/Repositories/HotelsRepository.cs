using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repositories
{
    public class HotelsRepository : GenericRepository<Hotel>
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}