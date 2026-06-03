using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using LeaveTracker.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Persistence;

public class BankHolidayRepository : Repository<BankHoliday>, IBankHolidayRepository
{
    public BankHolidayRepository(LeaveTrackerSQLDBContext dbContext) : base(dbContext)
    { }

    public async Task<IEnumerable<BankHoliday>> GetAllByYearAsync(int year)
    {
        return await _dbSet.Where(b => b.Date.Year == year).ToListAsync();
    }
}
