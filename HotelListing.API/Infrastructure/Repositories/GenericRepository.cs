using HotelListing.API.Core.AbstractionsAndContracts;
using HotelListing.API.Data.Contexts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
	private readonly HotelListingDbContext _context;
    public GenericRepository(HotelListingDbContext hostelListingDbContext)
    {
        this._context = hostelListingDbContext;
    }
    public async Task<T> AddAsync(T entity)
	{
		await _context.AddAsync(entity);
		await _context.SaveChangesAsync();
		return entity;
	}

	public async Task DeleteAsync(string? id)
	{
		var entity = await GetAsync(id);
		_context.Set<T>().Remove(entity);
		await _context.SaveChangesAsync();
	}

	public async Task<bool> Exists(string id)
	{
		var entity = await GetAsync(id);
		return entity != null;
	}

	public async Task<List<T>> GetAllAsync()
	{
		return await _context.Set<T>().ToListAsync();
	}

	public async Task<T?> GetAsync(string? id)
	{
		/*if (id is null)
		{
			return null;
		}*/
		return await _context.Set<T>().FindAsync(id) ?? null;
	}

	public async Task UpdateAsync(T entity)
	{
		_context.Update(entity);
		await _context.SaveChangesAsync();
	}
}
