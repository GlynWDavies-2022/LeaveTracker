using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Interfaces;

public interface IBankHolidayRepository : IRepository<BankHoliday>
{
    public Task<IEnumerable<BankHoliday>> GetAllByYearAsync(int year);
}
