
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Domain.Entities;

public class Hotel : Entity, IAuditable
{
    public string Name { get; set; }

    public string Address { get; set; }

    public string Rating { get; set; }
    public DateTimeOffset CreatedAt { get; }
	public DateTimeOffset UpdatedAt { get; }

    // Relational Prop
    [ForeignKey(nameof(CountryId))]
    public string CountryId { get; set; }
    public Country Country { get; set; }
}

