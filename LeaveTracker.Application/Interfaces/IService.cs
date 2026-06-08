using LeaveTracker.Domain.Entities;
using System.Linq.Expressions;

namespace LeaveTracker.Application.Interfaces;

public interface IService<T> where T : BaseEntity
{
    public Task CreateAsync(T entity);
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<T?> GetByIdAsync(int id);
    public Task UpdateAsync(T entity);
    public Task DeleteAsync(T entity);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
}
