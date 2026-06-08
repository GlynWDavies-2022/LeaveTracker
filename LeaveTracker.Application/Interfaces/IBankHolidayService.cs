using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Interfaces;

public interface IBankHolidayService
{
    public Task<IEnumerable<BankHoliday>> GetAllAsync();

    public Task<IEnumerable<BankHoliday>> GetAllByYearAsync(int year);
}
