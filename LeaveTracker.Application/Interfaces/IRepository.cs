using LeaveTracker.Domain.Entities;
using System.Linq.Expressions;

namespace LeaveTracker.Application.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    public Task CreateAsync(TEntity entity);
    public Task<IEnumerable<TEntity>> GetAllAsync();
    public Task<TEntity?> GetByIdAsync(int id);
    public Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity,bool>> predicate);
    public void Update(TEntity entity);
    public void Delete(TEntity entity);

    public Task<int> SaveChangesAsync();
}
