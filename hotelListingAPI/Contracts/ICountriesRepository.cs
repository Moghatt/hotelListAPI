using hotelListingAPI.Data;

namespace hotelListingAPI.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
