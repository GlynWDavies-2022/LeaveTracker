using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using System.Linq.Expressions;

namespace LeaveTracker.Application.Services;

public class Service<T> : IService<T> where T : BaseEntity
{
    private readonly IRepository<T> _repository;

    public Service(IRepository<T> repository)
    {
        _repository = repository;
    }

    public virtual async Task CreateAsync(T entity)
    {
        ValidateEntity(entity);

        await _repository.CreateAsync(entity);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Id must be greater than 0", nameof(id));

        return await _repository.GetByIdAsync(id);
    }

    public virtual async Task UpdateAsync(T entity)
    {
        ValidateEntity(entity);

        _repository.Update(entity);

        await _repository.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _repository.Delete(entity);

        await _repository.SaveChangesAsync();
    }
    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        ArgumentNullException.ThrowIfNull(predicate);

        return await _repository.FindAsync(predicate);
    }

    protected virtual void ValidateEntity(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }
}
