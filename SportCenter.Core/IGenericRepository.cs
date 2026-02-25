using System.Linq.Expressions;

namespace SportCenter.Core;

public interface IGenericRepository<T>
    where T : class
{
    public async Task<T?> GetById(int id);
    public async Task Add(T entity);
    public async Task Update(T entity);
    public async Task Remove(int id);
    public async Task<List<T>> GetAll();
    public async Task<T?> FirstOrDefault(Expression<Func<T, bool>> predicate);
    public async Task<IQueryable<T>> GetQueryable();
}
