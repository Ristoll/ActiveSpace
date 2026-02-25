using System.Linq.Expressions;

namespace SportCenter.Core;

public interface IGenericRepository<T>
    where T : class
{
    public Task<T?> GetByIdAsync(int id);
    public Task AddAsync(T entity);
    public Task UpdateAsync(T entity);
    public Task RemoveAsync(int id);
    public Task<List<T>> GetAllAsync();
    public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    public Task<IQueryable<T>> GetQueryableAsync();
}
