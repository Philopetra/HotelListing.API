namespace HotelListing.API.Core.AbstractionsAndContracts;

public interface IGenericRepository<T> where T : class
{
	Task<T> GetAsync(string? id);

	Task<List<T>> GetAllAsync();

	Task<T> AddAsync(T entity);

	Task DeleteAsync(string? id);

	Task UpdateAsync(T entity);

	Task<bool> Exists(string id);

	//Task<T> FindById(string id);
}
