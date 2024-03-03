using HotelListing.API.Domain.Entities;

namespace HotelListing.API.Core.AbstractionsAndContracts
{
	public interface ICountryService: IGenericRepository<Country>
	{
		Task<Country> GetDetails(string id);
	}
}
