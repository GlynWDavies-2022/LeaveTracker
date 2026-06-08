using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Services;

public class BankHolidayService : Service<BankHoliday>, IBankHolidayService
{
    public BankHolidayService(IBankHolidayRepository repository) : base(repository)
    { }

    public DayOfWeek GetDayOfWeek(BankHoliday bankHoliday)
    {
        ArgumentNullException.ThrowIfNull(bankHoliday);

        return bankHoliday.Date.DayOfWeek;
    }
}
