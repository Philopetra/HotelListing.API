using AutoMapper;
using HotelListing.API.Core.Dtos.Country;
using HotelListing.API.Core.Dtos.Hotel;
using HotelListing.API.Domain.Entities;

namespace HotelListing.API.Infrastructure.Configurations;

public class AutoMapperConfig: Profile
{
    public AutoMapperConfig()
    {
        CreateMap<Country, CreateCountryDto>().ReverseMap();
		CreateMap<Country, GetCountryDto>().ReverseMap();
		CreateMap<Country, CountryDetailsDto>().ReverseMap();
		CreateMap<Country, UpdateCountryDto>().ReverseMap();

		CreateMap<Hotel, HotelDto>().ReverseMap();
	}
}
