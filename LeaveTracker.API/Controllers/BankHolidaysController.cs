using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LeaveTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankHolidaysController : ControllerBase
{
    private readonly IBankHolidayRepository _bankHolidayRepository;

    private readonly IRepository<BankHoliday> _repository;

    public BankHolidaysController(IRepository<BankHoliday> repository, IBankHolidayRepository bankHolidayRepository)
    {
        _repository = repository;

        _bankHolidayRepository = bankHolidayRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<BankHoliday>> GetAllBankHolidaysAsync()
    {
        return await _repository.GetAllAsync();
    }

    [HttpGet("{year}")]
    public async Task<IEnumerable<BankHoliday>> GetAllBankHolidaysByYearAsync(int year)
    {
        return await _bankHolidayRepository.GetAllByYearAsync(year);
    }
}
