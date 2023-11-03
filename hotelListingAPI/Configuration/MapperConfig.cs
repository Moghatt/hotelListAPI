using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models.Hotel;
using hotelListingAPI.Data;
using hotelListingAPI.Models.Country;
using hotelListingAPI.Models.Users;

namespace hotelListingAPI.Configuration
{
    public class MapperConfig:Profile
    {
       
        
            public MapperConfig()
            {
                CreateMap<Country, CreateCountryDto>().ReverseMap();
                CreateMap<Country, GetCountryDto>().ReverseMap();
                CreateMap<Country, CountryDto>().ReverseMap();
                CreateMap<Country, UpdateCountryDto>().ReverseMap();

                CreateMap<Hotel, HotelDto>().ReverseMap();

                CreateMap<ApiUserDto, ApiUser>().ReverseMap();

            }
        
    }
}
