using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Interfaces;

public interface IBankHolidayService : IService<BankHoliday>
{
    public DayOfWeek GetDayOfWeek(BankHoliday bankHoliday);
}
