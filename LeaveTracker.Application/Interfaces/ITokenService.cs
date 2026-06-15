using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Interfaces;

public interface ITokenService
{
    public string CreateToken(User user);
}
