using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using LeaveTracker.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

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

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
}
