
using HotelListing.API.Core.AbstractionsAndContracts;
using HotelListing.API.Data.Contexts;
using HotelListing.API.Domain.Entities;
using HotelListing.API.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Core.Services
{
	public class CountryService : GenericRepository<Country>, ICountryService
	{
		private readonly HotelListingDbContext _hotelListingDbContext;

		public CountryService(HotelListingDbContext hotelListingDbContext): base(hotelListingDbContext)
        {
			this._hotelListingDbContext = hotelListingDbContext;
		}

		public async Task<Country> GetDetails(string id)
		{
			return await _hotelListingDbContext.Countries.Include(x => x.Hotels).FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
