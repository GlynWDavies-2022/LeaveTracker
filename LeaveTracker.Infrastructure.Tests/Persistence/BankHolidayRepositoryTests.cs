using LeaveTracker.Domain.Entities;
using LeaveTracker.Infrastructure.Database;
using LeaveTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Tests.Persistence;

public class BankHolidayRepositoryTests
{
    private readonly BankHolidayRepository _repository;

    private readonly List<BankHoliday> _testBankHolidays;

    public BankHolidayRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<LeaveTrackerSQLDBContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var dbContext = new LeaveTrackerSQLDBContext(options);

        _testBankHolidays = new()
        {
            new BankHoliday { Id = 1, Date = new DateOnly(2024, 1, 1), Name = "New Year's Day" },
            new BankHoliday { Id = 2, Date = new DateOnly(2024, 12, 25), Name = "Christmas Day" },
            new BankHoliday { Id = 3, Date = new DateOnly(2025, 1, 1), Name = "New Year's Day" },
            new BankHoliday { Id = 4, Date = new DateOnly(2025, 12, 25), Name = "Christmas Day" },
            new BankHoliday { Id = 5, Date = new DateOnly(2026, 1, 1), Name = "New Year's Day" }
        };

        dbContext.BankHolidays.AddRange(_testBankHolidays);

        dbContext.SaveChanges();

        _repository = new BankHolidayRepository(dbContext);
    }

    [Fact]
    public async Task GetAllByYearAsync_WhenBankHolidaysExistForYear_ReturnsBankHolidays()
    {
        // Arrange

        var year = 2024;

        // Act

        var result = await _repository.GetAllByYearAsync(year);

        // Assert

        Assert.Multiple(() =>
        {
            Assert.NotNull(result);
            Assert.All(result, b => Assert.Equal(year, b.Date.Year));
            Assert.Equal(2, result.Count());
        });
    }

    [Fact]
    public async Task GetAllByYearAsync_WhenNoBankHolidaysExistForYear_ReturnEmptyList()
    {
        // Arrange

        var year = 2030;

        // Act

        var result = await _repository.GetAllByYearAsync(year);

        // Assert

        Assert.Multiple(() =>
        {
            Assert.NotNull(result);
            Assert.Empty(result);
        });
    }

    [Fact]
    public async Task GetAllByYearAsync_WhenMultipleYearsExist_ReturnsOnlyRequestedYear()
    {
        // Arrange

        var year = 2026;

        // Act

        var result = await _repository.GetAllByYearAsync(year);

        // Assert

        Assert.Multiple(() =>
        {
            Assert.NotNull(result);
            Assert.All(result, b => Assert.Equal(year, b.Date.Year));
            Assert.Equal(1, result.Count());
        });

    }
}
