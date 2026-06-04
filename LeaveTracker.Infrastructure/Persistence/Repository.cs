using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using LeaveTracker.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LeaveTracker.Infrastructure.Persistence;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly LeaveTrackerSQLDBContext _dbContext;

    protected readonly DbSet<TEntity> _dbSet;

    public Repository(LeaveTrackerSQLDBContext dbContext)
    {
        _dbContext = dbContext;

        _dbSet = _dbContext.Set<TEntity>();
    }

    public virtual async Task CreateAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();
    }
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
    public virtual async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }
    public virtual void Update(TEntity entity)
    {
        _dbSet.Update(entity);

        _dbContext.SaveChanges();
    }

    public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public virtual async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }


    public virtual void Delete(TEntity entity)
    {
        _dbSet.Remove(entity);

        _dbContext.SaveChanges();
    }
}
