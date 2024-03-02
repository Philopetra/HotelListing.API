using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data.Contexts;

public class HotelListingDbContext: DbContext
{
    public HotelListingDbContext(DbContextOptions options) : base(options)
    {
        
    }
}

