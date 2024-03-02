namespace HotelListing.API.Domain.Entities;

public class Country : Entity, IAuditable
{
    public string Name { get; set; } = string.Empty;
	public string CountryCode { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; }
	public DateTimeOffset UpdatedAt { get; }

	//Relational Props
	public virtual IList<Hotel> Hotels { get;}
}