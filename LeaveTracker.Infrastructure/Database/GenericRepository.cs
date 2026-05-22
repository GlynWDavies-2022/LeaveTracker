using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Database;

public class GenericRepository<T>(LeaveTrackerContext context) : IGenericRepository<T> where T : BaseEntity
{
    public void Add(T entity)
    {
        context.Set<T>().Add(entity);
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }


    public void Update(T entity)
    {
        context.Set<T>().Attach(entity);

        context.Entry(entity).State = EntityState.Modified;
    }

    public void Remove(T entity)
    {
        context.Set<T>().Remove(entity);
    }

    public async Task<bool> SaveAllAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public bool Exists(int id)
    {
        return context.Set<T>().Any(entity => entity.Id == id);
    }
}
