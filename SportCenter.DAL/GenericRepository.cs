using SportCenter.DAL.Data;
using System.Linq.Expressions;
using SportCenter.Core;

using Microsoft.EntityFrameworkCore;


namespace SportCenter.DAL;

public class GenericRepository<T> : IGenericRepository<T>

    where T : class
{
    private readonly DbSet<T> _entities;

    public GenericRepository(SportCenterDbContext context)
    {
        _entities = context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(int id)
        => await _entities.FindAsync(id);

    public async Task AddAsync(T entity)
        => await _entities.AddAsync(entity);

    public async Task UpdateAsync(T entity)
    {
        _entities.Update(entity);
        await Task.CompletedTask;
    }

    public async Task RemoveAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
            _entities.Remove(entity);
    }

    public async Task<List<T>> GetAllAsync()
        => await _entities.ToListAsync();

    public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        => await _entities.FirstOrDefaultAsync(predicate);

    public async Task<IQueryable<T>> GetQueryableAsync()
        => await Task.FromResult(_entities.AsQueryable());
}
