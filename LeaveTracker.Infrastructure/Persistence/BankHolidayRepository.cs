using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using LeaveTracker.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Persistence;

public class BankHolidayRepository : IBankHolidayRepository
{
    private readonly LeaveTrackerSQLDBContext _dbContext;

    public BankHolidayRepository(LeaveTrackerSQLDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<BankHoliday>> GetAllAsync()
    {
        return await _dbContext.BankHolidays.ToListAsync();
    }

    public async Task<IEnumerable<BankHoliday>> GetAllByYearAsync(int year)
    {
        return await _dbContext.BankHolidays
            .Where(bh => bh.Date.Year == year)
            .ToListAsync();
    }
}
