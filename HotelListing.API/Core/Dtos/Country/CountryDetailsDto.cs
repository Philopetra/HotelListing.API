using HotelListing.API.Core.Dtos.Hotel;

namespace HotelListing.API.Core.Dtos.Country;

public class CountryDetailsDto : BaseCountryDto
{
    public string Id { get; set; } = string.Empty;
    public List<HotelDto> Hotels { get; set; }


}
