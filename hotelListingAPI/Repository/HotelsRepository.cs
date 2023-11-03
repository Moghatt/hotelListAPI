using hotelListingAPI.Contracts;
using hotelListingAPI.Data;

namespace hotelListingAPI.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
