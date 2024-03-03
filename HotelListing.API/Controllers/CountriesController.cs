using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.API.Data.Contexts;
using HotelListing.API.Domain.Entities;
using AutoMapper;
using HotelListing.API.Core.Dtos.Country;
using HotelListing.API.Core.AbstractionsAndContracts;

namespace HotelListing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountriesController : ControllerBase
{
	private readonly IMapper _mapper;
    private readonly ICountryService _countryService;

	public CountriesController(IMapper mapper, ICountryService countryService)
    {
		this._mapper = mapper;
        _countryService = countryService;
	}

    // GET: api/Countries
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GetCountryDto>>> GetCountries()
    {
      /*if (_context.Countries == null)
      {
          return NotFound();
      }*/
      /*var countries = await _context.Countries.ToListAsync();*/

        var countries = await _countryService.GetAllAsync();

        var records = _mapper.Map<List<GetCountryDto>>(countries);
		return Ok(records);
    }

    // GET: api/Countries/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CountryDetailsDto>> GetCountry(string id)
    {
        /*if (_context.Countries == null)
        {
            return NotFound();
        }*/
        //var country = await _context.Countries.Include(x => x.Hotels).FirstOrDefaultAsync(x => x.Id == id);

        var country = await _countryService.GetDetails(id);

        if (country == null)
        {
            return NotFound();
        }
        var countryDto = _mapper.Map<CountryDetailsDto>(country);

        return Ok(countryDto);
    }

    // PUT: api/Countries/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCountry(string id, UpdateCountryDto updateCountryDto)
    {
        if (id != updateCountryDto.Id)
        {
            return BadRequest("Invalid Record Id");
        }

        // _context.Entry(country).State = EntityState.Modified;

        // var country = await _context.Countries.FindAsync(id);

        var country = await _countryService.GetAsync(id);

        if (country == null)
        {
            return NotFound();
        }
        var result = _mapper.Map(updateCountryDto, country);
        try
        {
            await _countryService.UpdateAsync(result);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (! await CountryExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Countries
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Country>> PostCountry(CreateCountryDto createCountryDto)
    {
       /* var countryOld = new Country
        {
            Name = createCountryDto.Name,
            CountryCode = createCountryDto.CountryCode,
        };*/

        var country = _mapper.Map<Country>(createCountryDto);

        await _countryService.AddAsync(country);

        return CreatedAtAction("GetCountry", new { id = country.Id }, country);
    }

    // DELETE: api/Countries/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCountry(string id)
    {
        var country = await _countryService.GetAsync(id);
        if (country == null)
        {
            return NotFound();
        }

        /*        _context.Countries.Remove(country);
                await _context.SaveChangesAsync();*/

        await _countryService.DeleteAsync(id);
        return NoContent();
    }

    private async Task<bool> CountryExists(string id)
    {
        /*  return (_context.Countries?.Any(e => e.Id == id)).GetValueOrDefault();*/
        return await _countryService.Exists(id);
    }
}
