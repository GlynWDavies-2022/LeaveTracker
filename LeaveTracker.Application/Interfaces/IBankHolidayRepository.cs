using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Interfaces;

public interface IBankHolidayRepository
{
    public Task<IEnumerable<BankHoliday>> GetAllByYearAsync(int year);
}
