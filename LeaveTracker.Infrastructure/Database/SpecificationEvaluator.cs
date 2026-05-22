using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Infrastructure.Database;

public class SpecificationEvaluator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQuery(IQueryable<T> query, ISpecification<T> specification)
    {
        if (specification.Criteria != null)
        {
            query = query.Where(specification.Criteria);
        }

        return query;
    }
}
