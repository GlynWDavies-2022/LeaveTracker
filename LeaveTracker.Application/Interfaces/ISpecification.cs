using System.Linq.Expressions;

namespace LeaveTracker.Application.Interfaces;

public interface ISpecification<T>
{
    public Expression<Func<T,bool>> Criteria { get; }
}
