using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    public Task<IEnumerable<TEntity>> GetAllAsync();
}
