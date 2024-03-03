using HotelListing.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HotelListing.API.Data.Contexts;

public class HotelListingDbContext : DbContext
{
	public HotelListingDbContext(DbContextOptions options) : base(options)
	{

	}

	public DbSet<Hotel> Hotels { get; set; }
	public DbSet<Country> Countries { get; set; }

	// Seeding of Data
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Country>().HasData(
			new Country
			{
				Id = "1",
				Name = "Nigeria",
				CountryCode = "NG"

			},
			new Country
			{
				Id = "2",
				Name = "Jamaica",
				CountryCode = "JM"
			},
			new Country
			{
				Id = "3",
				Name = "United States",
				CountryCode = "US"
			},
			new Country
			{
				Id = "4",
				Name = "Canada",
				CountryCode = "CA"
			},
			new Country
			{
				Id = "5",
				Name = "United Kingdom",
				CountryCode = "GB"
			},
			new Country
			{
				Id = "6",
				Name = "Australia",
				CountryCode = "AU"
			},
			new Country
			{
				Id = "7",
				Name = "India",
				CountryCode = "IN"
			},
			new Country
			{
				Id = "8",
				Name = "China",
				CountryCode = "CN"
			},
			new Country
			{
				Id = "9",
				Name = "France",
				CountryCode = "FR"
			},
			new Country
			{
				Id = "10",
				Name = "Germany",
				CountryCode = "DE"
			},
			new Country
			{
				Id = "11",
				Name = "Italy",
				CountryCode = "IT"
			},
			new Country
			{
				Id = "12",
				Name = "Brazil",
				CountryCode = "BR"
			},
			new Country
			{
				Id = "13",
				Name = "Russia",
				CountryCode = "RU"
			},
			new Country
			{
				Id = "14",
				Name = "Japan",
				CountryCode = "JP"
			},
			new Country
			{
				Id = "15",
				Name = "South Africa",
				CountryCode = "ZA"
			}
			
		);

		modelBuilder.Entity<Hotel>().HasData(
			new Hotel
			{
				Id = "1",
				Name = "The Breakers Palm Beach",
				Address = "1 South County Road, Palm Beach, Florida, USA",
				CountryId = "3",
				Rating = "4.8"
			},
			new Hotel
			{
				Id = "2",
				Name = "Park Hyatt Tokyo",
				Address = "3-3-1 Nishi-Shinjuku, Shinjuku-ku, Tokyo, Japan",
				CountryId = "14",
				Rating = "4.9"
			},
			new Hotel
			{
				Id = "3",
				Name = "Four Seasons Resort Bora Bora",
				Address = "Motu Tehotu, Bora Bora, French Polynesia",
				CountryId = "6",
				Rating = "5.0"
			},
			new Hotel
			{
				Id = "4",
				Name = "Gleneagles Hotel",
				Address = "Auchterarder, Perthshire, Scotland",
				CountryId = "5",
				Rating = "4.7"
			},
			new Hotel
			{
				Id = "5",
				Name = "Hotel Château Gütsch",
				Address = "Gütschstrasse 8, Lucerne, Switzerland",
				CountryId = "5",
				Rating = "4.9"
			},
			new Hotel
			{
				Id = "6",
				Name = "頤和園洲際酒店 (InterContinental Beijing Sanlitun)",
				Address = "32 Liangmaqiao Road, Chaoyang District, Beijing, China",
				CountryId = "8",
				Rating = "4.8"
			},
			new Hotel
			{
				Id = "7",
				Name = "One&Only The Palm",
				Address = "Palm Jumeirah, Dubai, United Arab Emirates",
				CountryId = "6",
				Rating = "4.7"
			},
			new Hotel
			{
				Id = "8",
				Name = "Ett Hem Stockholm",
				Address = "Nybrogatan 11, Stockholm, Sweden",
				CountryId = "11",
				Rating = "5.0"
			},
			new Hotel
			{
				Id = "9",
				Name = "COMO The Treasury",
				Address = "1 Cathedral Square, Perth, Australia",
				CountryId = "6",
				Rating = "4.9"
			},
			new Hotel
			{
				Id = "10",
				Name = "Six Senses Kaplankaya",
				Address = "Salihdede Mahallesi Kaplankaya Turkey",
				CountryId = "11",
				Rating = "4.8"
			}
		);

	}
}
