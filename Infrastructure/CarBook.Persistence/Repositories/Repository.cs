
namespace CarBook.Persistence.Repositories;
public class Repository<T>(CarBookContext _context) : IRepository<T> where T : class
{

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
    public async Task CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await SaveAsync();
    }
    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await SaveAsync();
    }
    public async Task RemoveAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await SaveAsync();
    }
    async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
