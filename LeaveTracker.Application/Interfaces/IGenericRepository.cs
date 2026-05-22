using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    public void Add(T entity);
    public Task<IReadOnlyList<T>> ListAllAsync();
    public Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification);
    public Task<T?> GetByIdAsync(int id);
    public Task<T?> GetEntityWithSpecification(ISpecification<T> specification);
    public void Update(T entity);
    public void Remove(T entity);
    public Task<bool> SaveAllAsync();
    public bool Exists(int id);
}
