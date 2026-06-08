using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Services;

public class BankHolidayService : IBankHolidayService
{
    private readonly IBankHolidayRepository _bankHolidayRepository;

    public BankHolidayService(IBankHolidayRepository bankHolidayRepository)
    {
        _bankHolidayRepository = bankHolidayRepository;
    }

    public async Task<IEnumerable<BankHoliday>> GetAllByYearAsync(int year)
    {
        return await _bankHolidayRepository.GetAllByYearAsync(year);
    }
}
