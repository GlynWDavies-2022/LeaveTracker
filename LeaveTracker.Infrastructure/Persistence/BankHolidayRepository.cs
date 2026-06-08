using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using LeaveTracker.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Persistence;

public class BankHolidayRepository : Repository<BankHoliday>, IBankHolidayRepository
{
    public BankHolidayRepository(LeaveTrackerSQLDBContext context) : base(context)
    { }

    public async Task<IEnumerable<BankHoliday>> GetAllByYearAsync(int year)
    {
        return await _dbSet
            .Where(bh => bh.Date.Year == year)
            .ToListAsync();
    }
}
