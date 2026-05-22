using LeaveTracker.Application.Interfaces;
using System.Linq.Expressions;

namespace LeaveTracker.Application.Specifications;

public class BaseSpecification<T>(Expression<Func<T,bool>> criteria) : ISpecification<T>
{
    public Expression<Func<T,bool>> Criteria => throw new NotImplementedException();
}
