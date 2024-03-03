using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Core.Dtos.Country;

public abstract class BaseCountryDto
{
    [Required] public string Name { get; set; } = string.Empty;
    public string CountryCode { get; set; } = string.Empty;
}
